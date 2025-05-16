### Ask Copilot to generate tests for a simple calculator example in JavaScript.

In this exercise, we'll ask GitHub Copilot to help us setup tests for this simple JavaScript calculator example. The calculator has a backend logic file `calculator.js` and a front-end logic file `index.html`. We'll write unit tests for the backend logic using Jest.

Jest is a popular testing framework for JavaScript, and it's widely used for testing JavaScript code. By setting up tests for the calculator example, developers can learn how to write unit tests for JavaScript code with the help of GitHub Copilot.

#### Instructions

1. **Setup the Project**:

   - Ensure you have Node.js installed.
   - Change directory to `exercise/javascript/simple-calculator`
   - Initialize a new Node.js project with `npm init -y`.

2. **Available Files**:

   - `calculator.js` file with the backend logic.
   - `index.html` file with the front-end logic.

3. **Write Unit Tests**:

   - Launch Chat and type this prompt:

   ```plaintext
       @workspace /setupTests setup unit tests for calculator.js. Save the file under exercise/javascript/simple-calculator.
   ```

   > You need to type `@workspace /setupTests` manually to trigger Copilot to help you set up tests for the `calculator.js` file.

   > Sometimes, Copilot may save the file in a different location. Ensure it's saved under `exercise/javascript/simple-calculator` by giving the exact folder location in your prompt.

   - Copilot will automatically generate the `calculator.test.js` file with the unit test scripts.
   - Follow the instructions on installing the jest package and running the tests.

4. **Run the Tests**:

   - Ensure your `package.json` contains this directive

   ```json
       "scripts": {
           "test": "jest"
       }
   ```

   - Run the tests with `npm test`.
   - Verify that the tests pass successfully.

5. **Verify the Results**:
   - Ensure all tests pass.
   - Modify the code and tests as needed to explore different scenarios.

**Errors?** Copy the errors and paste them into the chat, then ask Copilot to help you fix the errors.

**Optional:** Install Jest with `npm install jest --save-dev`. (If you haven't done so already)

6. **Run the App in the Browser**

We need to run this app using a simple http-server so we can test the front-end logic in the browser. Launch Chat and type this prompt:

Launch Chat and type this prompt:

```
I need to install the node http-server to run the front-end locally. provide me the steps to install and run the server.
```

Follow the instructions provided by GitHub Copilot to set up a simple HTTP server to test the front-end logic in the browser. It will most likely respond with these command (responses may vary):

```
npm install --save-dev http-server
```

Add a start script to your package.json:

```
"scripts": {
  "start": "http-server"
}
```

Run the server: `npm start`

Open your browser and navigate to http://localhost:8080 to test the front-end.

7. **Improve or Add Features**:

Use **GitHub Copilot Edits** to improve the code or add new features to the calculator.

- Launch GitHub Copilot Edits (Not the chat).
- Add `calculator.js`, `caculator.test.js` and `index.html` in the Working set
- Submit this prompt:

```plaintext
   We need to improve the calculator front-end and logic to ensure that it can perform all the basic arithmetic function. Add more features to the calculator and write additional tests to cover the new features.
```

- Observe. GitHub Copilot will take over the editor and start suggesting improvements to the code.
- Experiment! Add new features to the calculator and write tests to cover the new features.

Ask Copilot to improve the UI to make it look more like a real calculator. In the same Copilot Edit session, submit this prompt:

```
Let's improve the index.html to provide a real calculator interface.
``` 