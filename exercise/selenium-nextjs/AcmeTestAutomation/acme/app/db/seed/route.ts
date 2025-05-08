import bcrypt from 'bcrypt';
import { invoices, customers, revenue, users } from './placeholder-data';
import { getdb } from '@/app/db/sql';

async function seedUUID() {
  const db = getdb();
  db.serialize(() => {
    db.run(`
      CREATE VIEW IF NOT EXISTS uuid7 AS
      WITH unixtime AS (
          SELECT CAST((UNIXEPOCH('subsec') * 1000) AS INTEGER) AS time
      )
      SELECT PRINTF('%08x-%04x-%04x-%04x-%012x',
            (select time from unixtime) >> 16,
            (select time from unixtime) & 0xffff,
            ABS(RANDOM()) % 0x0fff + 0x7000,
            ABS(RANDOM()) % 0x3fff + 0x8000,
            ABS(RANDOM()) >> 16) AS next;
    `);
  });

  db.close();
}

async function seedUsers() {
  const db = getdb();
  const tasks: Promise<any>[] = [];

  db.serialize(() => {
    db.run(`
      CREATE TABLE IF NOT EXISTS users (
        id TEXT PRIMARY KEY,
        name VARCHAR(255) NOT NULL,
        email TEXT NOT NULL UNIQUE,
        password TEXT NOT NULL
      );
    `);

    db.run(`
      CREATE TRIGGER IF NOT EXISTS insert_users_id
        AFTER INSERT ON users FOR EACH ROW WHEN NEW.id IS NULL
      BEGIN
          UPDATE users SET id = (SELECT next FROM uuid7) WHERE ROWID = NEW.ROWID;
      END;
    `);

    db.run(`
      DELETE FROM users;
    `);

    users.map(async (user) => {
      tasks.push(bcrypt.hash(user.password, 10)
        .then((hashedPassword) => {
          db.run("INSERT INTO users (id, name, email, password) VALUES (?, ?, ?, ?)", user.id, user.name, user.email, hashedPassword);
        })
      );
    });
  });

  await Promise.all(tasks);
  db.close();
}

async function seedInvoices() {
  const db = getdb();
  db.serialize(() => {
    db.run(`
      CREATE TABLE IF NOT EXISTS invoices (
        id TEXT PRIMARY KEY,
        customer_id TEXT NOT NULL,
        amount INT NOT NULL,
        status VARCHAR(255) NOT NULL,
        date DATE NOT NULL
      );
    `);

    db.run(`
      CREATE TRIGGER IF NOT EXISTS insert_invoices_id
        AFTER INSERT ON invoices FOR EACH ROW WHEN NEW.id IS NULL
      BEGIN
        UPDATE invoices SET id = (SELECT next FROM uuid7) WHERE ROWID = NEW.ROWID;
      END;
    `);

    db.run(`
      DELETE FROM invoices;
    `);

    invoices.map((invoice) => {
      db.run("INSERT INTO invoices (customer_id, amount, status, date) VALUES (?, ?, ?, ?)", invoice.customer_id, invoice.amount, invoice.status, invoice.date);
    });
  });

  db.close();
}

async function seedCustomers() {
  const db = getdb();
  db.serialize(() => {
    db.run(`
      CREATE TABLE IF NOT EXISTS customers (
        id TEXT PRIMARY KEY,
        name VARCHAR(255) NOT NULL,
        email VARCHAR(255) NOT NULL,
        image_url VARCHAR(255) NOT NULL
      );
    `);

    db.run(`
      CREATE TRIGGER IF NOT EXISTS insert_customers_id
        AFTER INSERT ON customers FOR EACH ROW WHEN NEW.id IS NULL
      BEGIN
          UPDATE customers SET id = (SELECT next FROM uuid7) WHERE ROWID = NEW.ROWID;
      END;
    `);

    db.run(`
      DELETE FROM customers;
    `);

    customers.map((customer) => {
      db.run("INSERT INTO customers (id, name, email, image_url) VALUES (?, ?, ?, ?)", customer.id, customer.name, customer.email, customer.image_url);
    });
  });

  db.close();
}

async function seedRevenue() {
  const db = getdb();
  db.serialize(() => {
    db.run(`
      CREATE TABLE IF NOT EXISTS revenue (
        month VARCHAR(4) NOT NULL UNIQUE,
        revenue INT NOT NULL
      );
    `);

    db.run(`
      DELETE FROM revenue;
    `);

    revenue.map((rev) => {
      db.run("INSERT INTO revenue (month, revenue) VALUES (?, ?)", rev.month, rev.revenue);
    });
  });

  db.close();
}

export async function GET() {
  try {
    await seedUUID();

    const tasks = [
      seedUsers(),
      seedCustomers(),
      seedInvoices(),
      seedRevenue(),
    ];

    await Promise.all(tasks);

    return Response.json({ message: 'Database seeded successfully' });
  } catch (error) {
    return Response.json({ error }, { status: 500 });
  }
}