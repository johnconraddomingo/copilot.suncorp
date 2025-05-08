# Chat with your Data

To extend the capabilioties of GitHub Copilot, there's another called [Data Analysis for Copilot](https://marketplace.visualstudio.com/items?itemName=ms-vscode.vscode-copilot-data-analysis) that allows you to interact with your data.

To use this extension, simply install it from the Marketplace in VS Code. Once installed, you can interact with it via the Chat interface using the @data participant.

Of course, you would also need to have a CSV file to analyze. You can use the sample file provided below or use your own.

### Sample CSV File

[GitHub Copilot Sample Usage Data](./../exercise/csv/ghcp-sample-usage-data.csv)

## Features

### Data Analysis

This extension is designed for people who works a lot with CSV files and wants to perform analysis. It can clean up .csv files, perform advanced data analysis using statistical measures, graphs, and predictive models. The @data agent helps users make informed decisions by offering tailored insights and interactivity for data tasks.

### Python Code Execution

The extension can execute Python code using Pyodide and return the results. It can also retry executions in case of errors or failures to ensure better results.

### Exporting Code

You can export the Python code used for analysis and visualizations into a Jupyter Notebook or a plain Python file.

## How to Use

### Analyzing Data

To analyze a CSV file, enter a prompt such as "Analyze the file #<file name>" or a more specific prompt.

#### Exercise: Getting Statistical Analysis

- Open the file [ghcp-sample-usage-data.csv](./../exercise/csv/ghcp-sample-usage-data.csv)
- Launch GitHub Copilot Chat and paste the following prompt:

```
@data Analyze the file #file:ghcp-sample-usage-data.csv
```

> Note: When using the hashtag file (#file), you need to type this manually in order to select the file you want to analyze. [Instructor to show this in the demo.]

GitHub Copilot will generate detailed stastics and insights based on the data in the CSV file.

### Exercise: Generating Visualizations

Let's now generate some visualizations based on the data.

You can request the generation of visualizations (charts, plots, etc.) by providing follow-up prompts.

- In the same chat window, paste the following prompt:

```
@data Generate a line chart for the column "Total Active Users" by "day" from the file #file:ghcp-sample-usage-data.csv
```

### Exercise: Generating an Area Chart

- In the same chat window, paste the following prompt:

```
@data Generate an area chart comparing the total number of suggestions versus acceptances by day
```

Copilot will generate an Area chart comparing the total number of suggestions versus acceptances by day using different colors for each series.
