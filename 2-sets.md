# Sets

### Introduction
What is the purpose of the data structure?
What is the performance of the data structure (you will need to talk about big O notation)?
What kind of problems can be solved using the data structure?
How would the data structure be used in C# (in some cases you will need to discuss recursion)?
What kind of errors are common when using the data structure?


### Operations
    - Membership Test: The primary operation of a set is to check if an element is a member, which is efficient due to hashing.
    - Performance: Using hashing, adding, removing, and checking for membership can typically be performed in O(1) time.
    - HashSet Class: Represents a set, providing O(1) performance for common operations assuming good conflict resolution.
    - Common Operations:
        Add(value): Adds a value to the set.
        Remove(value): Removes a value from the set.
        Contains(value): Checks if a value is in the set.
        Count: Returns the number of items in the set.
    - Mathematical Operations:
        Intersect: Finds common elements between sets.
        Union: Combines all elements from multiple sets.

### Hashing
    - Hashing Basics: Hashing transforms data into an integer (hash code) used to determine the index in a sparse array.
    - Example: For single-digit numbers, the index can be directly the number itself. For larger ranges, use modulo operation (e.g., index(n) = n % 10).
    - Sparse Arrays: Arrays used to store set elements may have many empty spots (sparse), and the index is calculated based on the hash code.

### Conflict Resolution
    - Open Addressing: If a collision occurs (same index), move to the next available spot.
        Issue: Can lead to clustering and degrade performance.
    - Chaining: Store conflicting elements in a list at the same index.
        Advantage: Avoids clustering but may increase lookup time.

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

You can check your code with the solution here: [Solution](sets-problem-solution)

Back to [Welcome Page](0-welcome.md)