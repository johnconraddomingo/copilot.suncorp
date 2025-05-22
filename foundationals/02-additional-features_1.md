# GitHub Copilot Additional Features Part 1

> Ask for a thumbs up

## Slide 14
![Slide 14](/images/docs-images/foundational/Slide-14.png)

# Introduction to slash commands

GitHub Copilot offers interactive features beyond passive code suggestions. Let's explore commands that can accelerate your workflow and handy tools for quick documentations, explaining code snippets, and locating files or functions.

Let's go to [slashdemo.js](/exercise/javascript/slashdemo.js) to see them in action.

# /doc
This is the slash command to ask GHCP to generate documentation comments for the selected code.

## Try it out

Quickly add documentation in the form of comments quickly just by highlighting an entire lines of code or fuction and pressing:

`Ctrl-i` then typing `/doc`

1. Highlight the getRandomInt function
2. Press Ctrl + i then in the inline chat, type /doc
3. Observe the suggestions

# /explain
This is the slash command to ask GHCP to explain the selected code.

## Try it out

Ask Copilot to explain a code snippet or entire function by launching the inline-chat:

`Ctrl-i` then typing `/explain`

Let's try it out.

1. Highlight the function calculateCircleArea
2. Press Ctrl + i then type /explain
3. Copilot will launch the Chat window where it will display the explanation

# /fix
This is the slash command to ask GHCP to fix errors in the selected code.

There are errors with the parseJsonString function in this file. Can you identify what they are? (Survey the group if anyone knows the answer)

## Try it out

Let's ask Copilot to identify and fix it.

1. Highlight the parseJsonString function
2. Press Ctrl + i, then type /fix
3. Review the suggestion from Copilot
4. Accept

# /fix from sub-menu

You can also invoke the /fix helper by right-clicking a line of code that has a syntax error (squigly red line), and selecting Copilot -> Fix This from the sub-menu.

## Try it out

Try it out on the the function findLargestNumber()

1. Highlight the findLargestNumber function
2. Right-click, find Copilot, then select Fix This

> Tip: You will see "Toggle changes" button beside the Discard button. Clicking this will show you the proposed changes.

# /test
This is the slash command to ask GHCP to write unit tests for the selected code.

### File to test

Let's go to the file we'll be creating unit tests for [utilities.js](/exercise/javascript/utilities.js).

GitHub Copilot can also help you save time by suggesting Unit Tests for you.

## Try it out

1. Make sure that functions in utilities.js are exported for testing
   - Type a comment at the end of the file `//Export the functions for testing`
2. Option 1: In utilities.js, right-click anywhere, then select Copilot -> Generate Tests
3. Option 2: In utilities.js, press Ctrl + i, then type /tests in the inline chat
4. Copilot will start suggesting the code and create the unit test file.
5. Click "Create", then "Accept". Copilot will automatically create the utilities.test.js file for you.

## Review the Unit Test file

Let's now review the unit test file created by Copilot

Let's go to [utilities.test.js](/exercise/javascript/utilities.test.js) to review the tests.

### Run the tests

> Requires JEST package

If you don't have JEST, please run this command

```
npm init -y && npm install --save-dev jest
```

### Execute the test

Let's run the unit test using JEST by executing this command from the Terminal

```
npx jest --coverage utilities.test.js
```

### --coverage

Instructs Jest to report code coverage

# One-Click Commit Message

Ever struggled on what to write as a commit message? With Copilot, it can help suggest draft commit messages for you.

- Navigate to Git Source Control.
- Look for the ✨ icon and click it.
- Copilot will suggest a commit message based on your changes.

**Remember:** If your commit includes multiple changes, Copilot will provide a commit message based recent changes but may not always suggest the best one. This is where you need to review and edit as needed before finalizing your commit.

## @Workspace

The @workspace feature in Visual Studio Code and GitHub Copilot Chat uses AI to offer context-specific assistance, such as project-relevant suggestions and navigation tips by analyzing your project's files and components.

## Ask Copilot to find a file or files based on your needs

(Open the Chat window)
```text
@workspace Search for python files where I can find helper functions that validates phone, email and url
```
Hit `Enter` and see what Copilot comes back with.


# @workspace - Analyze project


The @workspace command is more than a file finder.

Suppose you've just cloned a new project to work on, and you're eager to understand its core components—like the programming languages utilized and the functionalities it provides.

You can get a quick overview by using GitHub Copilot's chat feature. Simply input the following query:
 

# Quick Recommendations


You can also ask with @workspace on basic recommendations.

```text
@workspace based on leading practices, what are your recommendations that developers may need to follow to improve this application?
``` 

### Reminder: Copilot should not replace a full Code Analysis tool and the developer's intuition about the project

Copilot will provide this response if it cannot comply with your instructions

> Without seeing the actual code, it's hard to provide a comprehensive review. It would be beneficial to review the actual code files, check for code comments, consistent coding style, error handling, and other best practices.

# @terminal and @vscode

Domain specific helpers from GitHub Copilot

## @vscode - Ask questions about VS Code
```text
@vscode how do I disable the GitHub Copilot extension?
```
## @terminal - Ask how to do something in the terminal

```text
@terminal what is the GIT command to change the current repository to another remote repository using the terminal?
```

These handy helpers can provide you answers to questions relevant to VS Code or executing commands from the Terminal window.
  
> **Q&A**
> <br/>Do you need to take a break?