# Copilot Edits

Use Copilot Edits, also called Copilot Suggestions, to start an AI-powered code editing session where you can quickly iterate on code changes by using natural language. Based on your prompts, Copilot Edits autonomously writes the code across multiple files in your workspace. These edits are applied directly in the editor, so you can quickly review them in-place, with the full context of the surrounding code.

In this exercise, you'll learn how to use GitHub Copilot's editing capabilities within Visual Studio Code (VS Code) to efficiently enhance and expand a basic web application.

## Exercise: Consuming an API (JavaScript)

> Optional: Just for fun, identify a group of people who are comfortable developing in JavaScript and perform this exercise without GitHub Copilot. Then Compare the results with Copilot's suggestions with those who used it.

Let's ask Copilot to write a simple API on an existing file.

1. Open the [/exercise/javascript/refactor.js](/exercise/javascript/refactor.js) file in this project.
2. Launch a Copilot Edits session by pressing `Ctrl + Shift + i` in VS Code. Select the `Claude 3.5 Sonnet` model.
3. Ensure that refactor.js is in the Working set to include it in the Copilot Edits session.
4. Switch to the refactor.js file
5. Paste the following prompt in Copilot Edits:

```plaintext
Add functions in this file that calls this API endpoint: https://akabab.github.io/starwars-api/#alljson.
Return the following fields: id, name, homeworld, image.

And add a function that fetches the ID from the API using the /id/<id>.json and extract the same fields.
```

Ideally, we would want to break instructions into smaller tasks, but for this exercise, we'll keep it as a single prompt since they're related.

> Observe how Copilot writes the code autonomously in the refactor.js file. Once you're satisfied with the changes, click "Accept" and Save the file to apply the edits.

### Exercise: Test the API

Let's ask Copilot to write a test function for the API at the bottom of the refactor.js file.

- Return to refactor.js and in the Copilot Edits session, paste the following prompt:

```plaintext
Write a test function that fetches the API endpoint and logs the response to the console.
```

- Observe how Copilot writes the test function autonomously in the refactor.js file.
- Once you're satisfied with the changes, click "Accept" and Save the file to apply the edits.
- Test the API.
  - Lauch a PowerShell Terminal.
  - Change directory to `/exercise/javascript` in the terminal
  - Run `node refactor.js` to see the output.

You will have the opportunity to practice multi-file editing during the full exercise activities.

## Tip: Tackle One Task at a Time

When you're diving into GitHub Copilot Edits, focus on wrapping up one task at a time in each section. Once Copilot provides a suggestion, click "Accept," hit "Save All," and then test the changes. Once you're satisfied, commit your changes before clicking "Done" in the Copilot Edits window. This will kick off a fresh multi-file edit session for your next task.

If you want to go back to a previous commit, here's a handy Git command: `git reset --hard <commit hash id>`
Simply copy the commit hash ID and replace it in the command above.

If you want to be extra careful, try these commands:

```
git branch backup-before-reset
git reset --hard <hash id>
```

[![GitHub Universe 2024](https://img.youtube.com/vi/ZCkh1YUa9Io/0.jpg)](https://www.youtube.com/embed/ZCkh1YUa9Io?si=2D3Du46385DyKU3V)