# Copilot Chat Features

> Ask for a thumbs up

## Slide 16
![Slide 16](/images/docs-images/foundational/Slide-16.png)

So far, when we're talking to Github Copilot, if you look at the bottom right, next to the model, you'll see it says "Ask" as a default. If you click on it, you get options:
* Ask
* Edit
* Agent

We collectively call these "GitHub Copilot Chat Features" and that is what we will go through in the next couple of sections... Starting with... Ask. 

It all really started with just "Ask", and it wasn't branded as such in the beginning. It was called "GitHub Copilot Chat"

# GitHub Copilot Chat

Let's now explore the benefits of GitHub Copilot Chat, a conversational interface that allows developers to interact with GitHub Copilot in natural language and get instant feedback and suggestions for your code challenges or needs. 

In this bit, we'll cover the differences between the inline CTRL+i vs this chat window.

## New Session in Chat

Copilot Chat supports multiple sessions. Click on **...** at the top right of the Chat window and choose **Open Chat in New Window**.
Notice that you can drag it around. You can even turn it into an editor if you drag the tab to the middle.

## Quickly add Context
Another benfit of Copilot Chat is that it allows you to very easily add context. Let's see that in action

1. Let's go to [app.js](/exercise/javascript/config/app.js). While we're at it, let's have a look as well at [config.js](/exercise/javascript/config/config.js), which contains the configuration for our application
2. Put your cursor on the empty space in Line 5 of app.js. Notice in the chat window that it gets automatically added as a context: pretty much the same thing happens on inline prompting when you think about it.
3. Add this this prompt into the chat

``` plaintext
Can you please help me add a database connection logic here
```
Notice that it gives us an example, but it's not very specific to what we need.

4. This time, drag [config.js](/exercise/javascript/config/config.js) into the chat window so it can be added as a context. 

5. Now that the context is added, let's clear the chat window for new context

``` plaintext
Can you please help me add a database connection logic here
```
Notice that this time, we get a very specific answer. It gives us a database connection that uses the configuration as per my context. I didn't even change the prompt, but because we added context, we're telling Github Copilot to take these extra files into consideration.
  
## Understanding Prompt Crafting

Prompt crafting is the art of writing concise requests to obtain accurate and effective responses from GitHub Copilot chat. Mastering it ensures more efficient and precise AI-assisted coding.

### Prompt Crafting vs. Prompt Engineering

Prompt Engineering involves deliberate strategies to refine interactions with AI models, especially when crafting language model prompts for user interaction. Unlike Prompt Engineering, GitHub Copilot is fine-tuned for coding contexts, requiring developers to interact with it as they would with a fellow coder, albeit an AI one.

### Ask a non-coding question
Let's see how Chat will respond to a non-coding related question.

> `Provide me the recipe for a chicken casserole`

As anticipated, Copilot focuses on programming support and will not provide a recipe. GitHub's AI training ensures it prioritizes coding assistance.

## The three S's of Prompt Crafting

When using GitHub Copilot Chat, craft **`simple, specific, and short`** prompts to maximize the effectiveness of GitHub Copilot.

> Note: In Microsoft Learn, they also mentioned "Surround", utilising descriptive filenames and keep related files open. This is the same as what we've covered on our "Context as File" or "Neighboring tab" topic.

Below are some examples of prompts that are simple, specific, and short:

### **Create a Function:**
> "Define a Python function that calculates the factorial of a number."

Simple: The prompt targets a single, clear ask—defining a function.

Specific: It clearly states the function’s purpose is to calculate a factorial.

Short: The instruction is direct and to the point, avoiding excess detail.


### **Write a Test:**
> "Generate a Jest test for a React button click event."

Simple: The task is focused solely on test generation.

Specific: It specifies the test framework (Jest), the application type (React), and the event to test (button click).

Short: The prompt is succinct and contains no unnecessary verbiage.


### **Handle an Exception:**
> "Add error handling for a file-not-found exception in this JavaScript code."

Simple: The prompt requests addition of a single exception handling case.

Specific: It details the exception type "file-not-found" and the code context (JavaScript).

Short: The phrasing is compact, easily directing Copilot’s action.

## Support for multiple popular development languages

GitHub Copilot, powered by OpenAI's GPT model, is works really well in numerous programming languages, thanks to its training on a multitude of public repositories.


### Try it out

Let's now put Chat into the test if we ask it to produce suggestions for Java, Kotlin and Swift

> Launch GitHub Copilot Chat

Java:

> `Write a Java method called convertCelsiusToFahrenheit that takes a double parameter representing a temperature in Celsius and returns the temperature converted to Fahrenheit.`

Kotlin:

> `Create a Kotlin function named 'isPalindrome' that takes a String parameter and returns a Boolean indicating whether the input string is a palindrome or not. Include comments explaining the function logic.`

Swift:

> `Write a Swift function called 'fetchWeatherData' which takes a 'String' parameter representing a city name and uses an 'URLSession' task to request weather data from an API. The function should return the data asynchronously using a completion handler with a custom 'WeatherData' struct.`


# A Learning Tool Beyond Code

GitHub Copilot Chat goes beyond coding assistance. Like ChatGPT, it serves as a learning platform within the realm of software development, offering insights on programming concepts, development practices, and industry knowledge.

## Extend Your Knowledge with Copilot Chat

For queries on software methodologies, operational practices, or tech trends, consult Copilot Chat. Here are some non-code queries to explore:

### Launch Chat in Editor mode for a better real-estate view. Paste the questions below and show the responses.

> "What is DevOps and how can it make me more productive as a Developer?"

Copilot Chat can explain what DevOps is, detailing how CI/CD pipelines enhance workflow efficiency, automation speeds up development, and the collaboration it fosters.

> "What are the leading practices for an efficient Pull Request process?"

Learn the intricacies of quality pull requests with Copilot's advice on crafting focused changes, descriptive summaries, and the art of code reviews.

## Learning and Professional Development

Look to GitHub Copilot Chat as an informative aid for understanding new concepts, refining skills, or tackling career queries. It's an AI resource that aids your development journey.

AI tools like GitHub Copilot love roleplaying. You can use this to your advantage by asking Copilot to be your instructor.

### Try it out
Try this prompt.

```
You are a skilled instructor who makes it easy to understand complex topics. You come up with fun exercises to help your students learn by doing. Your goal is to teach students to be proficient with regular expressions. Move one step at a time and wait for the student to give the correct response before moving to the next concept. if the student provides a wrong answer give them a hint. Begin.
```

# Tips and Tricks

## Formatting assistance

Update markdown contents.

You can ask Copilot to help you format your markdown documentations.

### Try it out
1. Let's go to [demo.md](/exercise/markdown/demo.md).
2. Copy the contents below inside demo.md


Crafting engaging documentation is integral to the success of any project. Here's how to make yours stand out:

Identify Your Audience: Tailor your documentation to the knowledge level and needs of your readers, whether they're beginners or experts.
Use Clear Structure: Organize with headers, lists, and a table of contents. Consistency helps readers follow along and find information quickly.
Be Concise but Comprehensive: Provide complete information in a direct manner. Avoid fluff, but do explain jargon and complex concepts.
Incorporate Examples: Reinforce instructions and explanations with practical examples. Code snippets and case studies can clarify abstract points.
Review and Update: Ensure accuracy with regular reviews. Updating docs to reflect changes in the project keeps your audience well-informed.


3. Highlight the all the text, press Ctrl + i, then type `Format the first line as markdown title and the rest as markdown numbered list.`

## Generate user stories

Copilot can also help BAs and POs not just developers. It can also help you by generating user stories.

### Try it out

Ask Copilot Chat to Generate a user story for a retail shop manager managing in-store stocks.

## Generate Pseudocode

Copilot can also help you in generating pseudocode. This is very helpful for solution architects.

### Try it out

Generate a psuedocode for this user story for a retail application: 
As a retail shop manager, I want to have a system that allows me to manage in-store stocks, So that I can keep track of inventory, ensure products are always available for customers, and make informed decisions about reordering and discontinuing products.

Acceptance Criteria:

I can view a list of all products in the store along with their current stock levels.
I can update the stock level of a product when new stock arrives or when stock is sold.
The system alerts me when a product's stock level falls below a certain threshold.
I can view a report of products that are frequently out of stock.
I can view a report of products that have not been sold for a certain period of time.

## Sorting

You can also ask simple sorting assistance by highlight the text you want to sort, hitting Ctrl + i and typing 

### Try it out

1. Go to [requirements.txt](/exercise/python/requirements.txt).
2. In this file, select all the dependencies (excluding the comment)
3. Press Ctrl + i, then in type "Sort this list alphabetically"


```
Flask==1.1.2
gunicorn==20.0.4
numpy==1.18.5
pandas==1.0.5
matplotlib==3.2.2
scikit-learn==0.23.1
requests==2.24.0
beautifulsoup4==4.9.1
lxml==4.5.1
pytest==5.4.3
```
## Convert code from one language to another

Copilot can also help you in converting code from one language to another.

### Reminder: Although Copilot is capable of converting code, you should always review it's suggestions and make sure that the converted code's functionality is unchanged.


### Try it out

Convert this query to PostgreSQL

```text
SELECT a.column1,
       b.column2,
       c.column3,
       SUM(d.column4) AS total_column4,
       e.column5,
       f.column6,
       (SELECT MAX(x.column7) FROM table_x x WHERE x.column8 = b.column2) AS max_column7
FROM table_a a
JOIN table_b b ON a.id = b.a_id
LEFT JOIN table_c c ON b.id = c.b_id
JOIN table_d d ON c.id = d.c_id
LEFT JOIN table_e e ON d.id = e.d_id
LEFT JOIN (
    SELECT t1.column6, t2.f_id
    FROM table_t1 t1
    INNER JOIN table_t2 t2 ON t1.id = t2.t1_id
    WHERE t1.column9 = 'SomeValue'
) f ON e.id = f.f_id
WHERE a.column10 <= (SELECT AVG(column10) FROM table_a)
AND b.column11 IN (SELECT column11 FROM table_b GROUP BY column11 HAVING COUNT(*) > 1)
GROUP BY a.column1, b.column2, c.column3, e.column5, f.column6
HAVING SUM(d.column4) > 1000
CONNECT BY PRIOR a.id = b.a_id
ORDER BY a.column1 DESC, b.column2, total_column4
FETCH FIRST 50 ROWS ONLY;
```

## Brainstorm with GitHub Copilot

Copilot can help you in brainstorming by prompting it to ask you questions about your project that you might now have thought about.

### Try it out
Help me design a simple tic-tac-toe game. Ask me different questions to help me design a simple tic-tac-toe game.

## Chain of thought or Stepwise Strategy
Sometimes when you ask GitHub Copilot for help, it can give you answers in a whole blob of text and it may be difficult to catch up and understand what Copilot is saying. You can add this phrase to your prompt to make Copilot wait for you until you are ready.

```
Wait for the "Next" keyword before giving the next instruction. Begin
```

### Try it out
1. Open GitHub Copilot chat.
2. Enter this prompt.
```
I want to learn how to use ReactJS, TypeScript and Redux by creating a tic tac toe game. Give me the step by step instructions on how to build the app. Wait for the keyword "Next" to move to the next instruction. Begin
```


> **Q&A**
> <br/>Do you need to take a break?