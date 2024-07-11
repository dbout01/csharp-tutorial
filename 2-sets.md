# Sets

### Introduction
Imagine a box where each toy can only appear once; this is similar to a set in computing. Sets help manage a collection of unique items, making sure no duplicates are present. Operations like adding or checking if an item is in the set are very fast, typically O(1) on average, because sets use a special method called hashing to store items. Sets are particularly useful when you need to ensure no duplicates, such as when managing unique usernames. In C#, using sets can sometimes be tricky for beginners, especially when dealing with complex items that change over time, because managing how items are identified as unique (hashing) needs careful consideration.


### Operations
- Membership Test: The primary operation of a set is to check if an element is a member, which is efficient due to hashing.
- Performance: Using hashing, adding, removing, and checking for membership can typically be performed in O(1) time.
 - HashSet Class: Represents a set, providing O(1) performance for common operations assuming good conflict resolution.
- Common Operations:
    - Add(value): Adds a value to the set
    - Remove(value): Removes a value from the set.
    - Contains(value): Checks if a value is in the set.
    - Count: Returns the number of items in the set.
    - Mathematical Operations:
        - Intersect: Finds common elements between sets.
        - Union: Combines all elements from multiple sets.
![alt text](pictures/queues.png.png)

### Hashing
- Hashing Basics: Hashing transforms data into an integer (hash code) used to determine the index in a sparse array.
- Example: For single-digit numbers, the index can be directly the number itself. For larger ranges, use modulo operation (e.g., index(n) = n % 10).
- Sparse Arrays: Arrays used to store set elements may have many empty spots (sparse), and the index is calculated based on the hash code.

### Conflict Resolution
- Open Addressing: If a collision occurs (same index), move to the next available spot.
    - Issue: Can lead to clustering and degrade performance.
- Chaining: Store conflicting elements in a list at the same index.
    - Advantage: Avoids clustering but may increase lookup time.

### Efficiency of Common Operations



### Example
**Description**
Imagine you are organizing a conference and need to manage the list of unique participants. Participants may register multiple times by mistake, and you need a way to store only unique entries, discarding any duplicates automatically.

**Real World Application**
Managing unique elements is crucial in many real-world scenarios, such as maintaining lists of email addresses, product codes, or any collection where duplicates are not allowed. For instance, in a conference, ensuring each participant is listed only once helps in accurate headcount, badge creation, and communication.

**Identify the Strengths of the Data Structure**
Uniqueness: Automatically handles duplicates, ensuring each element is stored only once.
Efficient Membership Testing: Quickly checks if an element is present in the set.
Set Operations: Provides operations like union, intersection, and difference, which are useful for complex data management tasks.
How This Applies in Your Given Application
For a conference, using a set to manage participants ensures each individual is counted only once, even if they register multiple times. This simplifies the management process, ensuring accuracy and efficiency.

**Putting Those Two Things Together**
To manage unique participants for a conference, you will use the HashSet<T> class in C#. This ensures that each participant is stored only once, automatically discarding duplicate registrations.

**How to Use the Data Structure to Solve the Problem**
We won't build the set from scratch. Instead, we'll use the built-in HashSet<T> class in C# to manage the participants.

    using System;
    using System.Collections.Generic;

    public class ConferenceRegistration
    {
        public static void Main(string[] args)
        {
            HashSet<string> participants = new HashSet<string>();

            // Simulate participants registering
            RegisterParticipant(participants, "Alice");
            RegisterParticipant(participants, "Bob");
            RegisterParticipant(participants, "Alice"); // Duplicate registration

            Console.WriteLine("Unique Participants:");
            foreach (var participant in participants)
            {
                Console.WriteLine(participant);
            }

            // Check if a specific participant is registered
            string checkParticipant = "Alice";
            if (participants.Contains(checkParticipant))
            {
                Console.WriteLine($"\n{checkParticipant} is registered.");
            }
            else
            {
                Console.WriteLine($"\n{checkParticipant} is not registered.");
            }

            // Perform set operations (e.g., union with another set)
            HashSet<string> newRegistrations = new HashSet<string> { "Charlie", "David", "Alice" };
            participants.UnionWith(newRegistrations);

            Console.WriteLine("\nParticipants after adding new registrations:");
            foreach (var participant in participants)
            {
                Console.WriteLine(participant);
            }
        }

        private static void RegisterParticipant(HashSet<string> participants, string participant)
        {
            if (participants.Add(participant))
            {
                Console.WriteLine($"{participant} registered successfully.");
            }
            else
            {
                Console.WriteLine($"{participant} is already registered.");
            }
        }
    }
- Add Elements: Participants register and are added to the set using Add.
- Check Membership: Checks if a participant is already registered using Contains.
- Set Operations: Demonstrates the union operation with another set of new registrations using UnionWith.



### Problem to Solve: Name
    def manage_destinations():
        visited_places = set()
        # Function to add new places, avoiding duplicates
        def add_place(place):
            if place in visited_places:
                print(f"{place} has already been visited.")
            else:
                visited_places.add(place)
                print(f"New trip planned to {place}.")
        return add_place

    def main():
        add_new_place = manage_destinations()
        # Sample places (the user may add or modify these)
        add_new_place("Paris")
        add_new_place("Tokyo")
        # TO-DO: Implement logic to handle user input for adding new destinations
        # TO-DO: Add functionality to remove places or list all places

    if __name__ == "__main__":
        main()


You can check your code with the solution here: [Solution](sets-problem-solution)

Back to [Welcome Page](0-welcome.md)