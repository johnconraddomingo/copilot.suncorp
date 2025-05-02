# GitHub Copilot Agent

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

## Other Use-Cases
The Agent feature can also do things like code analysis and local environment setup. 

Let's say, you want to start a NextJS project, you can ask Copilot to scaffold a NextJS project on an empty workspace

```plaintext
I want to start a NextJS project. Can you please help me setup a local dev environment?
```