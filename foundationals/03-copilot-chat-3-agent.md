# GitHub Copilot Agent

> Ask for a thumbs up

## Slide 18
![Slide 18](/images/docs-images/foundational/Slide-18.png)

The GitHub Copilot Agent is an advanced feature of GitHub Copilot that acts as a context-aware assistant. It goes beyond traditional code suggestions by enabling developers to automate tasks and interact with their development environment in a more dynamic way. 

## Exercise: Creating a brand new application

Let's try this prompt:

```plaintext
Inside the *exercise/javascript/login* folder, I need you to create for me a login page made in HTML. I also want you to create a new .js file as validation script for submitting the form.
Use modern CSS Layout and Tailwind CSS.
```
What's peculiar about this prompt? How is it different from what we've done so far? **We did not give it a file to work with: Only the starting folder. And even then, the only reason we gave it a path is for organisation**

## Exercise: Multi-Step Tasks

You can also chain commands without even needing to open the file itself, highlighting or pointing to an exact spot. We can just talk to Copilot and give it commands.

Let's pretend we don't have unit tests yet. Let's go ahead and delete all the contents of [/exercise/javascript/utilities.test.js](/exercise/javascript/utilities.test.js)

Let's try this prompt:
```plaintext
Create unit tests for utilities.js and run it.
```

It's like having your own developer. You are in control, but you have someone right next to you facilitating what you need.

Following this same flow, let's open [/exercise/javascript/utilities.js](/exercise/javascript/utilities.js) and add "dude" in line 47

``` javascript
return `${firstName} ${lastName} dude`;
```

Now run unit tests again and read the results in the Chat window.

```plaintext
Run unit tests for utilities.js.
```

## Exercise: Build A Complete Application
Let's do a demo on a completely new workspace: All through prompts.
The point of this exercise is so that we can demonstrate that Agent Mode can create a workspace for you, add features, debug, refactor and create documentation.
What we're trying to build here is a To-Do list using WebSockets.

> Make sure that you create a completely new workspace for this exercise, just so you don't have to worry about the folder structure and the package.json potentially conflicting 

Run these prompts one after the other. Make sure you are using GPT-4o on Agent Mode:

1. **Creating:** Issue "Generate the boilerplate code for a Node.js Express server with WebSocket support."

2. **Adding a Feature:** Issue "Create a client application inside this same workspace that will allow me to create the post to the WebSocket and see it in action"

We asked Copilot to create the application inside the same workspace just so we don't have to go through the browser. You can optionally just ask "Create a client application that will allow me to create the post to the WebSocket and see it in action"

3. **Debugging Assistance:** We're going to introduce a bug in the code intentionally, like a typo or a missing variable. Issue "Why is the WebSocket broadcast not working?" This could be a bit tricky and could take a while to debug

4. **Code Search and Refactoring:** Issue "Find where the POST from the client page to the WebSocket server is implemented in this repo."

5. **Generate Documentation:** Issue "Please write a documentation for this Workspace"

## Other Use-Cases
The Agent feature can also do things like code analysis and local environment setup. 

Let's say, you want to start a NextJS project, you can ask Copilot to scaffold a NextJS project on an empty workspace

```plaintext
I want to start a NextJS project. Can you please help me setup a local dev environment?
```

> **Q&A**
> <br/>Do you need to take a break?