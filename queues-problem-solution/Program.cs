from queue import Queue

def setup_cooking_queue():
    cooking_tasks = Queue()
    # Enhanced with more diverse tasks
    tasks = ["Preheat oven to 180°C", "Chop vegetables", "Boil water", "Bake cake", "Grill chicken"]
    for task in tasks:
        cooking_tasks.put(task)
    
    return cooking_tasks

def main():
    cooking_queue = setup_cooking_queue()
    # Task execution logic implemented
    while not cooking_queue.empty():
        task = cooking_queue.get()
        print(f"Task completed: {task}")
        # Example of task handling logic
        # Additional code can be added here for detailed task management

if __name__ == "__main__":
    main()
