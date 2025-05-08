# Speaker Introduction

## Slide 2

![GenAI Overview Slide 2](/images/docs-images/00-intro-genai-overview/GenAI-Overview-Slide-2.png)

**Introductions**

**Reiterate the purpose of the foundations training**

# Generative AI Overview

## Slide 3

![GenAI Overview Slide 3](/images/docs-images/00-intro-genai-overview/GenAI-Overview-Slide-3.png)

To help developers understand how GitHub Copilot works, we will introduce Generative AI. Powered by models like OpenAI’s GPT, this technology predicts text instead of searching for it. GitHub Copilot uses these capabilities, running on Azure, to provide intelligent code suggestions. 

**Ask the audience if they know what ChatGPT is**
  
> ChatGPT is a conversational AI model developed by OpenAI. It's a large language model that can generate human-like text based on the input it receives.
  
Let's jump back to the topic at hand... Generative AI, at its core, is about creating new content—be it text, images, music, or videos. And it's in the word itself... Generative, that is to say... *to generate*.

AI models use large amounts of publicly available training data to create new content that resembles what they were trained on. Therefore, “training” means providing a model with lots of data so it can learn patterns and generate similar content.

We'll show an example of this generation concept in a little bit. Let's continue with the slides.

We've already talked about these first three items, so I'm just going to ram through them at once: Generative AI, generates new content using training data as patterns and as an example. Gen AI *does not* search the internet. It's not a search engine, it learns from the data that it's been provided to predict or to generate new material: That's why people use AI to create new stories, new iteniraries, new music. It's not searching the internet and stealing other people's work. It's not purely relying on a database and going, *this is the only list i'm going to rely on*. It generates new stuff, and it's the exact same concept if we're trying to apply the same thing to coding. 

- **Show the Azure OpenAI Playground.** Prepare the Azure Portal and show the Azure OpenAI Studio
- **Alternative:** ChatGPT or GitHub Copilot from the Browser if you don't have access to Azure OpenAI Studio
 
What I'm going to do now is some simple Prompt Engineering. I will instruct the model to complete a sentence.

Here's the Instructions:

```
Model Instructions: You are an AI assistant that helps people find information. Complete the sentence that the user provides.
```

And here's a sample prompt:

```
It's a sunny day outside, and I'm craving for...
```

### Exercise: GitHub Copilot in the browser

Let's try GitHub Copilot chat in the browser.

- Open a new browser tab
- Navigate to [GitHub Copilot](https://github.com/copilot). Login with your GitHub account if you haven't already.
- Paste this prompt: "It's a sunny day outside, and I'm craving for..."

> Don't be surprised if it says It cannot assist with your request. Since your prompt isn't technincally coding related, it might not provide a response.

> But there's a workaround! Try this prompt:

```
Complete this sentence using a python funciton: "It's a sunny day outside, I want to go to the..."
```

By providing a coding-related prompt, GitHub Copilot will now treat that as coding related prompt, and will now provide a suggestion. This is why Context is important when working with AI tools, such as GitHub Copilot.
 
### Knowledge Cut-off

There's something called a knowledge cut-off, which means our AI models only know up to a certain point in time. It's like an author who hasn't read the latest books or news and can't update their knowledge on their own.

| Model             | Knowledge-Cutoff Date |
| ----------------- | --------------------- |
| GPT-4o            | October 2023          |
| o1-and o1 mini    | October 2023          |
| Claude 3.5 Sonnet | April 2024            |
| Claude 3.7 Sonnet | August 2024           | 

> **Share this URL** https://github.com/HaoooWang/llm-knowledge-cutoff-dates
> 
> **You can also show an example asking Github Copilot when their last knowledge cutoff is. Make sure you change the model dropdown accordingly**

Finally, we can enhance these AI models using techniques like Function Calling, Retrieval Augmented Generation (RAG), or fine-tuning. This is similar to giving our artist new tools or lessons to improve their skills and creativity. These topics are more advanced and require a deeper dive, so we're not going to cover them in this session.

## Slide 4

![GenAI Overview Slide 4](/images/docs-images/00-intro-genai-overview/GenAI-Overview-Slide-4.png)

Let's have a look at this image for an overview of just how Github Copilot works with data. 
So from our IDE, we feed Copilot with the context of our question: that means the codes that we need to be looked at, the other relevant codes, manual input telling the result that we're expecting and other relevant information. It then goes to Copilot's backend service which relies on a large language model (LLM) to generate responses or code suggestions using publicly available data combined with the context

## Slide 5

![GenAI Overview Slide 5](/images/docs-images/00-intro-genai-overview/GenAI-Overview-Slide-5.png)

GitHub Copilot is an IDE extension that integrates directly into your development environment, such as Visual Studio Code. It provides real-time code suggestions, similar to how ESLint checks for coding errors and styling issues, helping you stay focused on development.
 
Additionally, GitHub Copilot is available on GitHub.com through a browser:

- Use it as a general chat interface, similar to ChatGPT, to generate code snippets or brainstorm ideas. Simply visit [GitHub Copilot](https://github.com/copilot) and log in with your GitHub account.
- Chat about your repository directly from the browser. If you have access to GitHub Copilot on GitHub.com, you can launch the chat interface by clicking the GHCP icon in the top navigation when viewing a repository. This is useful when you need to work on a repo but don't have your IDE set up yet or are new to the project.

## Slide 6

![GenAI Overview Slide 6](/images/docs-images/00-intro-genai-overview/GenAI-Overview-Slide-6.png)

GitHub Copilot (GHCP) is an extension, not standalone software. Like other tools, it enhances productivity by integrating into your development environment.

## Slide 8

![GenAI Overview Slide 8](/images/docs-images/00-intro-genai-overview/GenAI-Overview-Slide-8.png)

To use GitHub Copilot (GHCP), you need a license tied to a GitHub account (personal or corporate). During authentication, GitHub.com checks your license and, if valid, provides a Copilot token. Your IDE plugin then uses this token to send prompts to the Copilot Proxy, which works with OpenAI GPT models to suggest code in your IDE. This process ensures only authorized users get AI-driven suggestions, preserving both functionality and compliance.
 
## Slide 9

![GenAI Overview Slide 9](/images/docs-images/00-intro-genai-overview/GenAI-Overview-Slide-9.png)

* The Copilot Proxy Service manages key tasks like user authentication, sentiment analysis to block abusive language, and filters for security, basic PII, and duplicates. It also has an Open Source Software (OSS) filter to avoid reusing potentially copyrighted code.

* You can switch on the OSS filter in your GitHub Organization settings to screen out code that might be copyrighted, even if it was public. This way, you won’t get identical copies of someone else's code.

If Copilot offers code that seems copyrighted, you can reword your request to push Copilot to create a different version. For example, instead of “Generate a simple HTML for signing up for a newsletter,” try “Create an HTML form with an email field and a message saying ‘Subscribe to our newsletter to keep yourself updated.’” 

## Slide 10

![GenAI Overview Slide 10](/images/docs-images/00-intro-genai-overview/GenAI-Overview-Slide-10.png)

**Trust, but verify** is the guiding principle when using GitHub **Copilot**. Think of Copilot as a smart assistant in your workshop. While it's incredibly **powerful**, it might sometimes suggest code that isn't quite right or optimal. Just like you wouldn't take advice without checking, always **verify** its suggestions to ensure your code is **accurate** and **reliable**.

**Context Awareness**: Imagine Copilot as a newcomer to your project. It might not fully grasp the specific details or requirements. The way I always look at it is like talking to a human. You don't just slide across to Abi, give her bad code and tell her.. "Fix this", and expect her to fix your code. She needs context. What did you want to get fixed? What's broken? Is there anything specific that you wanted me to improve?

**Code Quality**: Think of it like proofreading a document. Automated code generation might not always align with your project's **standards** or **best practices**. By verifying, you maintain high-quality, consistent code—just like editing a draft to perfection.

**Learning Opportunity**: By reviewing and understanding Copilot's suggestions, you can enhance your own coding skills. It's like learning a new language; the more you engage with it, the better you become.

**Trust, but verify!**
You are the pilot. GitHub Copilot is only your assistant, not the source of truth. 

### GitHub Copilot Trust-Center

For more information about GitHub Copilot's security and compliance measures, visit the [GitHub Copilot Trust-Center](https://copilot.github.trust.page/faq#ip-and-open-source).
 