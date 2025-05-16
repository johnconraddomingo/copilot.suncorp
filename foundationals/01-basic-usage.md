# Basic Usage

## IDE Choices

**Demonstrate how to use GitHub Copilot on IntelliJ and Visual Studio**

## Demos

In this demo, we're going to explore the core functionality of GitHub Copilot, which is Code Completion. 

We are going to learn the basics of how you can leverage this AI-powered tool to enhance your coding experience.


# Context is Key

Context provides the necessary backdrop that informs the purpose and function of the code. 

For GitHub Copilot, context comes from comments, code structure, and opened files that guide the AI to generate relevant and useful suggestions. 

### Try it out

1. Let's go to [demo.py](/exercise/python/demo.py).

2. Paste the following comment in the file.
```python
# Question: What are the popular Python data visualisation modules?
# Answer:
```

3. After pasting the comment, put your cursor after the colon in "Answer:" and press the `Spacebar`


> Remember to use the language-specific commenting symbols. This ensures you don't get syntax errors and Copilot can accurately interpret your intent and offer the most suitable suggestions for your code.

## Vague or unclear comments

Using vague or unclear comments can cause Copilot to suggest unexpected code.

## Try it out

1. Let's go to [demo.js](/exercise/javascript/demo.js).

2. Delete any existing code and comment in this file. We'll test  how GitHub Copilot responds with vague requests.
3. Paste the following comment in the file.
```javascript
// Generate a function that will perform calculations`
```

4. Press `Enter` twice start from the end of the comment. Press `Tab` once you see Copilot's suggestion then `Enter`. Continue pressing `Tab` then `Enter` until Copilot completes the function definition.

Because the comment lacks additional context, it will suggest the most likely code based on its knowledge.

> Note: Suggestions may differ from others

Notice that vague comments may yield unexpected suggestions from GitHub Copilot. For precise, useful code generation, always provide clear, specific comments to guide its suggestion.


# Clear Comments

Let's see some more code completions. Let's give GitHub Copilot clearer context on what we're trying to do by adding the following comment to the file line of the tasks.js file. 

## Try it out

1. Let's go to [tasks.js](/exercise/javascript/tasks.js).

2. Paste the following comment in the file.
```javascript
// A simple task list manager in JavaScript that allows users to add, mark complete, and delete tasks.
```

3. Press `Enter` twice after the comment.

4. Then accept Copilot's suggestions by pressing the `Tab` then `Enter` key as you see the suggestions come up.

5. Press these key combinations until you see this suggestion.
```javascript
// Print the tasks array
printTasks();
```

## Testing the function

### Node.JS required

Let's run and test what Copilot suggested in the terminal. 

> Option 1


`node exercise\javascript\tasks.js`

> Option 2

`cd exercise\javascript`

`node tasks.js`

Remember to Save the File before executing the above command in the terminal.

### Complete a task

After the last addTask() line, press `Enter` twice then start typing `compl`, Copilot will suggest the completeTask() function including a task to complete. Accept this then run the code again.

> Key take away: Providing a clear context or "goal" for Copilot will increase the chances of yeilding the most relevant suggestions.


# Additional Suggestions

## Try it out

1. Let's go to [demo.js](/exercise/javascript/demo.js). 

2. Delete all the contents of demo.js. 
3. Let's get Copilot help us create a new function. Then we will ask it for additional suggestions (when available). 

4. Type or copy paste below at the top of demo.js

```javascript
// Create a function that calculates the sum of the two lowest numbers given an array of 5 positive integers. Display the two lowest numbers in the array.
```
There used to be a dedicated pane for going throug h Copilot's suggestions, but in the newer releases, that's been replaced by **Alt+]**

> Demo Tip: Rephrase the comment or a different function name if Copilot fails to generate additional suggestions.


## Ask help with Refactoring

**Refactoring** is the process of restructuring existing code without changing its external behavior. Its primary **_purpose is to improve_** the nonfunctional attributes of the software, making it easier to comprehend, reducing its complexity, and enhancing its maintainability.


## Inline Chat 

In this topic, we will cover the inline chat, where you can interact with GitHub Copilot using natural language directly from the file you're editing.

## Shortcuts (VS Code)

To launch Inline-chat, simply press these key combination

### Cmd (⌘) + i  for Mac
### Ctrl + i for Windows

## Try it out

Let's go to [refactor.js](/exercise/javascript/refactor.js).

This getAdultNames function can be refactored using modern JavaScript features to be more concise and readable. Here's how you could ask GitHub Copilot to help with the refactoring:

1. Highlight the getAdultNames function in the code editor.
2. Activate Github Copilot's inline chat feature. (`Ctrl + i or Cmd + i`)
3. Ask Copilot, "Please refactor this function to use more modern JavaScript syntax and make it more efficient"


## Ask help with error handling

### Error Handling

Let's go to [errorhandler.py](/exercise/python/errorhandler.py).

This python code reads the contents of the config.json file located in the same folder.
But right now, it will only work on a "Happy path". If the file doesn't exist of the json is malformed, the function won't be able to handle it gracefully.

### Show errors (Trainer)

**Malformed JSON**
1. Open config.json and add a stray comma at the end (to make it malformed). Save.
2. change dir to exercise\python
3. Execute `python errorhanlder.py` from the terminal

This will produce an error related to the malformed json.

**Unknown filename**
1. Correct config.json by removing the stray comma
2. Inside errorhandler.py, change config.json to configs.json (with an 's')
3. Execute the code

This will produce a file not found error.

## Try it out

Now, let’s see how to ask GitHub Copilot to suggest error handling:

1. Highlight the entire read_config function.
2. Activate GitHub Copilot's inline chat feature.
3. Ask Copilot, "Add error handling to this function to manage non-existent file paths and handle invalid JSON content gracefully"

Accept the suggestion, then test the code again with the following scenarios:

- Malformed config.json
- Correct config.json, but wrong filename


## Other language support

Code suggestions for other languages.

> Tip: Viewing the HTML - Right click the Tab with title "demo.html", then select "Reveal in File Explorer. Double click demo.html.

## Try it out

Let's try the code completions again, this time with an HTML.

1. Let's go to [demo.html](/exercise/html/demo.html).
2. Paste the following comment into the file.
```html
<!--Generate an HTML scaffolding. Add a simple top nav, a hero banner and a Call to action using Tailwind CSS. Include dummy texts-->
```

3. Press `Enter` at the end of the comment, review and accept the suggestions until complete.

> Tip: If Copilot does not provide a complete code suggestion, or it's taking a while to Tab and Enter, simply highlight the code, including your comments at the top, press Ctrl + i then type `Complete this HTML`. 

4. Once Copilot completes the HTML, save the file the view the HTML in a browser. 

5. Right click the Tab with title `demo.html`, then select `Reveal in File Explorer`. Double click demo.html.


## Context from files

## Files as Context

GitHub Copilot can provide better suggestions the more context you provide it. Besides using clear comments, meaningful names for functions and variables, having related files open can also help GitHub Copilot to generate more relevant suggestions, which we will see in the next demo.


# Context file

Let's go to [utilities.js](/exercise/javascript/utilities.js).

`utilities.js` is a sample javascript file with helper functions. 

Instead of just the function definition, each functions are defined with the appropriate documentation, such comments about the parameters and the return value.

Let's open demo.js again and repeat the previous demo where we've asked Copilot to produce a function the performs a calculation between two numbers.

## Using Files as Context

### Try it out

1. Let's go back to [demo.js](/exercise/javascript/demo.js). 

2. Let's first delete the existing code inside demo.js (if any). Copy and paste the comment below inside the demo.js. (Alternatively, hit CTRL+I)

```javascript
// Generate a function that calcualtes the volume of a cylinder given its radius and height. Include the measurement units as part of the output.
```

3. Hit Enter twice starting at the end of the comment.
4. Review and Accept the suggestions provided by Copilot.

Remember how Copilot suggested the function definition


### Suggestions based on other files

Copilot will now suggest a function with a similar pattern from the opened file `utilities.js`.

## Suggestions based on Context

### Neighboring Tabs or opened files

Notice how GitHub Copilot used the pattern from the open file on suggesting how to write the function. Without explicitly asking it to do so, it suggested documentation (comments) about the function. Copilot uses opened file or also known as "neighboring tabs" as additional context to recommend suggestions.

If you recall our first demo, it immediately went on to suggest the function definition without describing the parameters and the output.

## What if you want to override the suggestion?

Simple: Reject the suggestion and start typing how you want the code to look like, then Copilot will start suggesting again based on what you've written.

So, if you don't want Copilot to use a specific way of writing code, you will have to take the wheel and drive.

# Recap of Basic Usage

## Probabilistic, not deterministic

GitHub Copilot is fundamentally a predictive tool that leverages a Large Language Model to suggest **probable code** snippets, **not guaranteed solutions**, based on the context and patterns in your coding.

> Trust, but Verify

## Clear Comments

Providing clear context to GitHub Copilot significantly improves your chances of receiving the most relevant and optimal code suggestions. Context is Key and Precision matters.

## Additional suggestions (when available)

When available, the **'Additional Suggestions pane'** in GitHub Copilot offers developers different versions of code suggestions, giving you choices to best fit your specific requirements.

## Four T's 

When using Code Completions, remember these Four T's

- Tab (Accept)
- Tweak (Accept then refine)
- Take the time to review additional/alternate suggestions
- Trash (Reject then iterate)

# Basic Usage Questions

> 5 mins Q&A