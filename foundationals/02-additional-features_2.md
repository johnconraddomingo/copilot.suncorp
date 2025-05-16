# GitHub Copilot Additional Features Part 2

## Pre-requisites

Some of the exercises will require Node.js installed on your machine. You can download the latest version of Node.js from the [official website](https://nodejs.org/).

## Different AI Models for Copilot Chat

Let's talk about the different AI models. Github copilot *acts* like a frontend. Although as a blanket term we say "let's ask Github copilot", the reality is that: it's not really Github Copilot that does the heavy lifting. It's the models: And developers have the opportunity to choose from a variety of models, each tailored with unique strengths, offering more flexibility and control in their coding tasks. Below is an overview of the available models:

> Note: Models apart from GPT-4o need to be enabled in the GitHub Copilot section under the Organization settings.
>
> **1. GPT-4o**
> * Description: The default model for Copilot Chat. It is highly versatile, offering reliable assistance in both text and > code generation tasks.
> * Strengths:
>   * Fast and efficient.
>   * Handles a wide range of tasks, from simple queries to coding assistance.
>   * Ideal for day-to-day use in software development.
> 
> **2. GPT-4.1**
> * Description: A more advanced version of GPT-4o, specializing in complex reasoning and understanding nuanced instructions.
> * Strengths:
>   * Advanced reasoning capabilities.
>   * Suitable for debugging, technical writing, and detailed code explanations.
>   * Provides in-depth and accurate answers for challenging scenarios.
> 
> **3. Claude 3.5 Sonnet**
> * Description: Developed by Anthropic, this model excels in collaborative software development and explaining intricate > coding concepts.
> * Strengths:
>   * Proficient in debugging and code reviews.
>   * Provides clear, concise, and precise coding solutions.
>   * Ideal for teams working on software projects collaboratively.
> 
> **4. Claude 3.7 Sonnet**
> * Description: An upgraded version of Claude 3.5, offering enhanced abilities for technical collaboration and > problem-solving.
> * Strengths:
>   * Faster and more accurate than Claude 3.5.
>   * Better at understanding context and providing in-depth explanations.
>   * Excels at multi-step problem-solving in software development.
> 
> **5. Gemini 2.0 Flash**
> * Description: A lightweight model optimized for quick responses and real-time coding assistance.
> * Strengths:
>   * Highly responsive with low latency.
>   * Best suited for on-the-fly coding needs and real-time collaboration.
>   * Maintains a balance between speed and accuracy.
> 
> **6. Gemini 2.5 Pro**
> * Description: A more advanced version of Gemini 2.0, designed for complex code generation and technical problem-solving.
> * Strengths:
>   * Superior accuracy for intricate coding tasks.
>   * Handles complex logic and multi-step reasoning.
>   * Suitable for experienced developers tackling challenging projects.
> 
> **7. o1**
> * Description: Specializes in advanced reasoning tasks and is ideal for scientific and mathematical computations.
> * Strengths:
>   * Excels at technical reasoning.
>   * Suitable for projects requiring mathematical precision or scientific rigor.
>   * Slower, but more accurate for specialized tasks.
> 
> **8. o3**
> * Description: A balanced model combining reasoning capabilities with faster response times.
> * Strengths:
>   * Good for intermediate-level problem-solving.
>   * Offers a balance between speed and reasoning depth.
>   * Ideal for users needing quick, moderately complex solutions.
> 
> **9. o3-mini**
> * Description: A lighter, faster version of o3, optimized for real-time assistance with minimal latency.
> * Strengths:
>   * Provides quick responses for straightforward coding tasks.
>   * Best suited for iterative development and fast-paced workflows.
>   * Less accurate for highly complex reasoning.
> 
> **10. o4-mini**
> * Description: The latest in the "o" series, designed for quick and efficient coding assistance with improved reasoning > over its predecessors.
> * Strengths:
>   * Faster and more accurate than earlier "mini" models.
>   * Ideal for developers seeking real-time solutions with reasonable accuracy.
>   * Great for prototyping and iterative development.

Ultimately, the strength of each model is determined by you. For example, I found that GPT is very weak in Azure DevOps pipelines, but Claude does a better job. GPT though is very good at Github Actions... And there is no scenario where I've ever found Gemini to be useful. Maybe that's changed since the last time i've used it. If that's so, then good job, but Gemini is always my last pick. 

If you don't get what you're after from one model, then ask the same question to another model, and see if it gives you a better result!

  [![GitHub Universe 2024](https://img.youtube.com/vi/FhVuX6Pyo9k/0.jpg)](https://www.youtube.com/embed/FhVuX6Pyo9k?si=sq_vnkLqxFtqtyWc)

 
## GitHub Copilot in GitHub.com (Browser)

> This is only available if your GitHub Organization has enabled the Copilot in GitHub.com feature.

GitHub Copilot is now available directly in your browser on GitHub.com. This feature allows you to access Copilot's AI-powered suggestions without leaving your browser, making it easier to collaborate with your team and review code changes on the go.

> Note: Your code must be in GitHub repos in order to use Copilot in GitHub.com. GitHub indexes your repository to provide AI-powered suggestions based on your codebase.

### Demo: Copilot in GitHub.com

Navigate to a repository in GitHub.com

You can find the Copilot Chat icon at the top area of the repository page. Click on the icon to open the Copilot Chat interface. It will show `Chat with Copilot` when you hover over the icon.

#### Chat about your repo

- What can you tell me about this repository
- What is the overall purpose of this repo?
- What languages are used in this repo?
- Are there any terraform exercises in this repo?

> If your repo is not indexed yet, Copilot will automatically index it when you ask your first question. It may take a while depending on how big is your repo. Once the indexing is complete, you can start chatting with Copilot.

## Demo: Custom Instructions 

To enforce specific development patterns or custom instructions when interacting with GitHub Copilot Chat, use [Custom Instructions](/docs/copilot-instructions.md).

> We might need a fresh repo for this example

Save this markdown file in your local `.github` folder if it doesn't exist yet. Each time you use GitHub Copilot Chat, this file will load automatically and provide custom instructions for Copilot to follow during your interactions.
 
### Example Use Case

To have GitHub Copilot always add a specific comment in its code suggestions, add the following instructions to your [.github/copilot-instructions.md](/):

```
Whenever you add new code to any files in this project, include this comment:

// Copilot Generated Code
```

The GIF below demonstrates how to use Custom Instructions in GitHub Copilot Chat.

![Custom Instructions Chat](/images/docs-images/gifs/Custom-Instructions-Chat.gif)

### Exercise: Sample Custom Instructions

Here are other samples of custom instructions. You can add any instructions you want, but the recommendation is that the instructions **should be short, self-contained statements that add context or relevant information to supplement users' chat questions**. You can experiment with different variations until you find the instructions that can help you speed up your development workflow when chatting with GitHub Copilot.

- Open copilot-instructions.md found under the `docs/copilot-instructions.md` path in your project.
- Copy this file into your .github folder in your project.
- Modify the instructions to suit your project's requirements.

For example:

```plaintext
Each time you generate code, add a comment `<YourName> is the greatest!` at the beginning of each code snippet.
```

```plaintext
We use npm for package management in this project. Ensure that all code suggestions include the necessary npm packages based on the context.
```

```plaintext
We always write JavaScript with double quotes and tabs for indentation, so when your responses include JavaScript code, please follow those conventions.
```

```plaintext
Our team uses Azure DevOps for tracking items of work.
```

> This helps GitHub Copilot give suggestions relevant to Azure DevOps. For example, when you ask it to generate details of a work item, it can suggest common fields used in "User Story" or "Bug" work items in Azure DevOps.

These instructions give context to GitHub Copilot, making its code suggestions more relevant to your project's needs. Custom Instructions save you from typing these details every time you use Copilot.

## GitHub Copilot Official Features Documentation

For more information on GitHub Copilot's official features, visit the [GitHub Copilot Documentation](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features).
