# Queues

### Introduction
What is the purpose of the data structure?
What is the performance of the data structure (you will need to talk about big O notation)?
What kind of problems can be solved using the data structure?
How would the data structure be used in C# (in some cases you will need to discuss recursion)?
What kind of errors are common when using the data structure?


### Grocery Store Queue
    Dequeue: When the item at the front is removed from the queue
    Enqueue: When a new person joins the queue at the back
        Data cannot be entered in the middle of the queue
        Used when we need to process a collection of requests in a fair and orderly way
    Two common queues: Web Server Queue and the Reader/Writer Queue

### Web Server Queue
    When a request is sent, it is put into a queue until the web server can process the request. In this way, all requests are received and none of them are lost
    Queues frequently have a self-imposed maximum size. If a queue is full, then the software may need to send an error message back to the client

### Reader/Write Queue
    Process/thread: the need to run different software components concurrently
    Each process will likely have their own set of variables that are maintained. Frequently, there is need to have shared data between the processes
    A queue is used to ensure order and integrity
    When a process wants to write, it is enqueued. When a process is dequeued, it is then allowed to modify the shared variable
    When the process is done, then the next process is dequeued.

### Running Test Cases
    Testing importance in software development
    Utilizing inline test code in C# for function validation
    Contrasting manual result checking with Trace.Assert for automated assertion and error reporting
    Handling testing complexities, such as setting up scenarios involving multiple function calls
    Testing aids in understanding software requirements
    Role of testing in Continuous Integration/Continuous Deployment (CI/CD) models
    Ensuring software updates don't introduce new issues through rigorous testing
    Automation of assert statements for comprehensive code coverage and efficient testing

### Efficiency of Common Operations


### Example
* Example description- describe the problem or the requirements and then show the student how to get to the answer
* Real world application
* Identify the strengths of the data structure
* Come up with how this applies in your given application
* Put those 2 things together
* how to use the data structure to solve a problem, not how to build the data structure
```Example code```

### Problem to Solve: Name
```What is supposed to be displayed```

You can check your code with the solution here: [Solution](queues-problem-solution)

Back to [Welcome Page](0-welcome.md)