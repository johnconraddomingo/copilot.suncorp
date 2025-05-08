import sqlite3 from 'sqlite3';

export const SQLITEDB_PATH = './app/db/database.db';

const getdb = () => new sqlite3.Database(SQLITEDB_PATH);

function sql<T> (query: string, params?: any): Promise<T> {
  const db = getdb();
  return new Promise((resolve, reject) => {
    db.all(query, params, (err, rows) => {
      if (err) {
        reject(err);
      }
      resolve(rows as T);
    });
  });
}

export { getdb, sql };