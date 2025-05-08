# GitHub Copilot with Selenium automation

In this ACME application, we will explore how GitHub Copilot can help to write UI automation tests faster and more efficiently using Selenium with C#.

## Demo - GitHub Copilot Code Completion Exercise

In this exercise, we will use GitHub Copilot to generate code snippets for Selenium automation tests.

## Setup acme application locally
To setup acme application locally, follow the [Readme.md](../exercise/selenium-nextjs/AcmeTestAutomation/acme/README.md) file.

## Open acme automation tests in Visual Studio
1. Double-click the [AcmeTestAutomation.sln](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeTestAutomation.sln) to open AcmeAutomation tests in Visual Studio 2022.
2. Navigate to [InvoicePage.cs](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeApplicationTest/Pages/InvoicesPage.cs) file.
2. Navigate to [InvoicePage.cs](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeApplicationTest/Pages/InvoicesPage.cs) file.

3. Let's now try below scenarios one-by-one to explore how GitHub Copilot will assist in automating these tests.

## Scenario 1 : Create Invoice for a Customer in Create Invoice page

### Context: Generate IWebElements from application code for Create Invoice page
1. In Create Invoice page, for this scenario, the first step is generate IWebElements for Customer dropdown, Amount textbox, two radio buttons, Cancel & Save buttons.

2. Using GHCP it can be done from two ways, by using the application code or by using the browser.

3. In this example, we will use the application code to generate IWebElements

4. In the class file [InvoicePage.cs](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeApplicationTest/Pages/InvoicesPage.cs) press Alt + \ for inline GHCP chat window to appear, enter # symbol to refer to this html file "//acme/app/ui/invoices/create-form.tsx" and copy and paste this below text
   ```csharp
   declare IWebElements as XPaths for customer dropdown, amount textbox, status radio buttons, cancel invoice, save invoice button from this file #create-form.tsx
   ```

5. GitHub Copilot chat suggests the following code
   ```csharp
   // GitHub Copilot Generated Code
   // Customer dropdown for selecting a customer
   private IWebElement CustomerDropdown => _driver.FindElement(By.XPath("//select[@id='customer']"));

   // Amount textbox for entering invoice amount
   private IWebElement AmountTextbox => _driver.FindElement(By.XPath("//input[@id='amount']"));

   // Radio buttons for invoice status
   private IWebElement PendingRadioButton => _driver.FindElement(By.XPath("//input[@id='pending']"));
   private IWebElement PaidRadioButton => _driver.FindElement(By.XPath("//input[@id='paid']"));

   // Buttons for invoice actions
   private IWebElement CancelButton => _driver.FindElement(By.XPath("/a[contains(@href, '/dashboard/invoices') and contains(@class, 'flex h-10')]"));
   private IWebElement SaveButton => _driver.FindElement(By.XPath("//button[@type='submit' and text()='Create Invoice']"));
   ```

6. Now cross verify these elements in the Developer tools console window to ensure all the fields are declared correctly by GitHub Copilot.

7. In the browser, enter the following url http://localhost:3000, navigate to Invoices page, select Create Invoice button, press F12.

8. In the developer tools, go to console table
select each element XPath and paste in the following manner in the console window, for example:
   ```js
   $x("//button[@type='submit' and text()='Create Invoice']")
   ```

8. If this XPath is successful, the query will display the element, and when the user hovers over the element, it will highlight in the DOM. If the XPath is unsuccessful, it will display as empty brackets [], and the user has to explore different options to retrieve the correct XPath.

## Scenario 2 : Write CREATE INVOICE and SAVE INVOICE methods with the help of comments

### Write ``CreateInvoice`` and ``SaveInvoice`` methods by writing comments in the class file

1. In the [InvoicePage.cs](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeApplicationTest/Pages/InvoicesPage.cs) class file after declaring all the IWebElements, in the next line, enter comments as
   ```csharp
   // write a method to create invoice and save invoice
   ```

2. Based on the context of this class file GitHub Copilot will provide ghost text for the method to create invoice

### Add Create Invoice test in the UITests file
1. Navigate to [UITests.cs](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeApplicationTest/UITests.cs) class file

2. Add new test ```VerifyCreateInvoice``` method to execute Create Invoice method.

3. Write comments to be very specific for GitHub Copilot to predict and suggest the correct content
   ```csharp
   //add login steps with username and password as "user@nextmail.com", "123456", navigate to UITests class file, click Create Invoice button, enter the values in Create Invoice page as("Delba de Oliveira","Amy Burns", "500"), Save the Invoice
   ```

4. GitHub Copilot sometimes suggests the entire method, at times we have to keep entering tab at each of line of suggestion.
   ```csharp
   [Fact]
   public void VerifyCreateInvoice()
   {
       _loginPage.ClickLoginButton();
       _loginPage.EnterLoginDetails("user@nextmail.com", "123456");
       Thread.Sleep(2000);
       _invoicesPage.ClickInvoicesLink();
       Thread.Sleep(2000);
       _invoicesPage.ClickCreateInvoiceButton();
       _invoicesPage.CreateInvoice("Delba de Oliveira", "1000", "Paid");
       _invoicesPage.SaveInvoice();
   }
   ```

## Scenario 3 : Write XPath for Search invoices text field in Invoices page using application code

### Context: Get the  XPath for specific element using application code
1. XPath is used to find an element and interact with it to perform an action.

2. If the tester has access to the application code, locate the file where Invoice page UI code is located.

3. Then navigate to the [search.tsx](../exercise/selenium-nextjs/AcmeTestAutomation/acme/app/ui/search.tsx) file

4. Identify the code and select that particular HTML block

5. Copy and paste this text in the GitHub Copilot chat window
   ```html
   write XPath for this element
   <input
     className="peer block w-full rounded-md border border-gray-200 py-[9px] pl-10 text-sm outline-2 placeholder:text-gray-500"
     placeholder={placeholder}
     onChange={(e) => {
       handleSearch(e.target.value);
     }}
     defaultValue={searchParams.get('query')?.toString()}
   />
   ```

6. Update the placeholder attribute of the HTML block to "Search invoices..."
   ```html
   <input
     ...
     placeholder="Search invoices..."
     ...
   />
   ```

7. GitHub Copilot chat suggests the following code
   ```csharp
   "//input[@placeholder='Search invoices...']"
   ```

8. Now validate this element in the Developer tools console window to ensure the XPath is correctly suggested by GitHub Copilot.

## Scenario 4 : Write XPath for Edit icon in Invoices page using application website
1. In this scenario, we will explore how to write XPath for the Edit icon(pencil icon) field in the Invoices page using application website.

2. In the browser, enter the following url http://localhost:3000, navigate to Invoices page, Highlight Edit pencil icon in the first row, right-click select Inspect Element

3. This opens developer tools, copy particular DIV element

4. In Visual Studio, open GitHub Copilot chat, paste the div element
   ```html
   Write XPath for the first row of this HTML element

   <a class="rounded-md border p-2 hover:bg-gray-100" href="/dashboard/invoices/01954a3a-1f4f-775c-b787-219290255673/edit"><svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" aria-hidden="true" data-slot="icon" class="w-5"><path stroke-linecap="round" stroke-linejoin="round" d="m16.862 4.487 1.687-1.688a1.875 1.875 0 1 1 2.652 2.652L6.832 19.82a4.5 4.5 0 0 1-1.897 1.13l-2.685.8.8-2.685a4.5 4.5 0 0 1 1.13-1.897L16.863 4.487Zm0 0L19.5 7.125"></path></svg></a>
   ```

4. GitHub Copilot chat suggests the following code
   ```csharp
   //table/tbody/tr[1]//a[contains(@href, '/dashboard/invoices/') and contains(@class, 'rounded-md border p-2 hover:bg-gray-100')]
   ```

5. Now validate this element in the Developer tools console window to ensure the XPath is correct

## Scenario 5 : Use extension method in Create Invoice and Edit Invoice methods

### Context: Refactor methods using GitHub Copilot
1. In [InvoicePage.cs](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeApplicationTest/Pages/InvoicesPage.cs) class file look for the following code
   ```csharp
   SelectElement select = new SelectElement(CustomerDdl);
   select.SelectByText(customer);
   ```

2. This is written in two places ```CreateInvoice``` and  ```EditInvoice``` methods

3. As part of coding best practices - reusability, write a method separately which is refactored to resue these lines multiple times.

4. GitHub Copilot chat suggests the ghost text
   ```csharp
   //write method for select dropdown
   public static void SelectDropDown(IWebElement element, string value)
   {
       SelectElement select = new SelectElement(element);
       select.SelectByText(value);
   }
   ```
5. Update ```CreateInvoice``` and ```EditInvoice``` methods to use this new method, this line of code will select the customer name from the dropdown in both Create Invoice page, Edit Invoice page.
   ```csharp
   SelectDropDown(CustomerDdl, customer)
   ```

## Scenario 6 : Update tests using GitHub Copilot

### Context: Support requirement changes using GitHub Copilot
Due to requirement change, there is a code change to add Confirm Delete modal box when the user clicks on the Delete icon

### Implement a change to Delete Invoice
> To skip this section, you can use the provided [confirm-delete.tsx](../exercise/selenium-nextjs/AcmeTestAutomation/acme/app/ui/invoices/confirm-delete.tsx) file and update the [table.tsx](../exercise/selenium-nextjs/AcmeTestAutomation/acme/app/ui/invoices/table.tsx) file to use the new button.

1. Open Copilot Chat and start a create a new Edits thread. Enter the following prompt.
   ```
   Create a DeleteInvoiceWithConfirmation component in a new file that shows a modal to confirm the operation.
   ```

   Add the [button.tsx](../exercise/selenium-nextjs/AcmeTestAutomation/acme/app/ui/button.tsx) and the [table.tsx](../exercise/selenium-nextjs/AcmeTestAutomation/acme/app/ui/invoices/table.tsx) files as reference.

2. GitHub Copilot should create a new file as well as suggest changes to the existing table.tsx file.

3. You may need to iterate on the suggestions to fix all the issues and make the code work (i.e.: missing `use client;`, form submit not working, etc)

4. In the browser, enter the following url http://localhost:3000, navigate to Invoices page, click Delete icon in the first row, the Delete modal box should now appear.

### Rerun the test
1. Run the existing automation tests, DeleteInvoice test fails due to an existing element update in the website

2. Ask GHCP for an explanation of the error

3. GHCP suggests that DeleteInvoiceIcon element is not found

#### For reference:
Below changes are required to update the existing tests due to this code change

In [InvoicePage.cs](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeApplicationTest/Pages/InvoicesPage.cs) class file
1. Update existing DeleteInvoiceIcon IWebElement

2. Add CancelButton, DeleteButton IWebElements for the Confirm Delete modal

3. Update ```DeleteInvoice``` method to click new Delete button

### Fix existing DeleteInvoiceIcon XPath
1. In the browser, enter the following url http://localhost:3000, navigate to Invoices page,

2. Highlight Delete icon, right-click select Inspect Element, this opens developer tools, copy particular DIV element

3. In Visual Studio, open GitHub Copilot chat, paste the DIV element and enter this text at the same time
   ```html
   Write XPath for the first row of this HTML element
   <button type="submit" class="rounded-md border p-2 hover:bg-gray-100"><span class="sr-only">Delete</span><svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" stroke-width="1.5" stroke="currentColor" aria-hidden="true" data-slot="icon" class="w-5"><path stroke-linecap="round" stroke-linejoin="round" d="m14.74 9-.346 9m-4.788 0L9.26 9m9.968-3.21c.342.052.682.107 1.022.166m-1.022-.165L18.16 19.673a2.25 2.25 0 0 1-2.244 2.077H8.084a2.25 2.25 0 0 1-2.244-2.077L4.772 5.79m14.456 0a48.108 48.108 0 0 0-3.478-.397m-12 .562c.34-.059.68-.114 1.022-.165m0 0a48.11 48.11 0 0 1 3.478-.397m7.5 0v-.916c0-1.18-.91-2.164-2.09-2.201a51.964 51.964 0 0 0-3.32 0c-1.18.037-2.09 1.022-2.09 2.201v.916m7.5 0a48.667 48.667 0 0 0-7.5 0"></path></svg></button>
   ```

4. GitHub Copilot chat suggests the following code
   ```csharp
   //table/tbody/tr[1]//button[@type='submit' and contains(@class, 'rounded-md border p-2 hover:bg-gray-100')]
   ```

### Locate IWebElements for Delete modal box
1. In Customer invoice table, click Delete icon in the first row
Delete modal box appears

2. Open developer tools by pressing F12, copy particular DIV element by inspecting elements

3. In Visual Studio, open GitHub Copilot chat, paste the DIV element and enter this text
   ```html
   declare IWebElement for this HTML element
   <div class="mt-4 flex justify-end space-x-2"><button type="button" class="px-4 py-2 bg-gray-300 rounded-md">Cancel</button>
   <button type="submit" class="px-4 py-2 bg-red-600 text-white rounded-md">Delete</button>
   </div>
   ```

4. GitHub Copilot chat suggests the following code
   ```csharp
   public IWebElement CancelButton => _driver.FindElement(By.XPath("//button[text()='Cancel']"));
   public IWebElement DeleteButton => _driver.FindElement(By.XPath("//button[text()='Delete']"));
   ```

5. Now cross verify these elements in the Developer tool console window to ensure all the fields are declared correctly by GitHub Copilot
   ```js
   $x("//button[text()='Cancel']")
   $x("//button[text()='Delete']")
   ```

### Update DeleteInvoice method to click the new Delete IWebElement
1. Navigate to existing method ```DeleteInvoice``` in [InvoicePage.cs](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeApplicationTest/Pages/InvoicesPage.cs) file

2. Press enter after `DeleteInvoiceIcon.Click();` to add a new line

3. GitHub Copilot suggests
   ```csharp
   DeleteButton.Click();
   ```

### Rerun DeleteInvoice test with the above changes
1. DeleteInvoice test will execute successfully

## Live exercise - Add tests in Customer page to search for Customer

### Using what you've learned so far, add a test to Search for a Customer in the Customer page, here are few guidelines to help you get started:
1. In [CustomerPage.cs](../exercise/selenium-nextjs/AcmeTestAutomation/AcmeApplicationTest/Pages/CustomerPage.cs) class file declare IWebElement for Customer search text field.

2. Next write a method to perform the operation.

3. Add a test method in the UITests class file
