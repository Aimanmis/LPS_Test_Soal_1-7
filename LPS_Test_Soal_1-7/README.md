# LPS Test - Soal 1.7

This repository contains a C# implementation for Soal 1.7 of the LPS Test.

## Soal1Class

The `Soal1Class` class addresses the task of retrieving the `shieldLastRun` property from the provided `Application` object. The method `GetLastRun()` checks for null conditions before accessing properties, ensuring safe and error-free code.

### Implementation Details

The `GetLastRun()` method is designed to safely retrieve the `shieldLastRun` property from the `Application` object. It employs conditional checks to handle potential null references, ensuring that the code executes without errors. This design promotes robustness and reliability in accessing properties.

## Soal2Class

The `Soal2Class` class introduces a method `GetInfo()` that returns an instance of the `ApplicationInfo` class. This design allows the method to effectively return more than one value by encapsulating them in an object. This approach enhances code clarity and maintainability.

### Implementation Details

The `GetInfo()` method is implemented to create and return an instance of the `ApplicationInfo` class, encapsulating multiple values related to application information. By adopting this design, the method provides a structured and cohesive response, facilitating better organization of data.

## Soal3Class

The `Soal3Class` class showcases modifications to the `Laptop` class by introducing a private member for the `Os` property. This modification enhances encapsulation and follows best practices for information hiding, allowing controlled access to the property.

### Implementation Details

The `Laptop` class has been modified by introducing a private member for the `Os` property, ensuring that modifications can be made using private members. This enhances encapsulation, limiting direct access to the property and promoting controlled modification through public methods or constructors.

## Soal4Class

The `Soal4Class` class addresses the issue of keeping references to objects unnecessarily, which can lead to memory leaks. The implementation ensures proper management of resources by periodically clearing the list, preventing unbounded memory growth.

### Implementation Details

The class includes a mechanism to address memory leaks caused by keeping unnecessary references. Objects in the list are periodically cleared, preventing the continuous accumulation of objects in memory. This strategy promotes efficient resource management.

## Soal5Class

The `Soal5Class` class provides an example implementation of events and event handlers in C#. It includes an `EventPublisher` class with a `MyEvent` event and an `EventSubscriber` class that subscribes to this event. This design enables the implementation of an event-driven architecture.

### Implementation Details

The `Soal5Class` demonstrates the implementation of events and event handlers in C#. It includes an `EventPublisher` class responsible for declaring and raising the `MyEvent` event. The `EventSubscriber` class subscribes to this event and responds by writing to the console, showcasing the fundamental concepts of event-driven programming.

## Soal6Class

The `Soal6Class` class addresses the issue of large object graphs that can lead to memory leaks. It includes a `TreeNode` class with a mechanism to add child nodes and periodically clear them to release memory. This approach ensures controlled memory usage in scenarios involving large hierarchical data structures.

### Implementation Details

The `Soal6Class` provides a solution for managing large object graphs to prevent memory leaks. The `TreeNode` class includes a mechanism to add child nodes and periodically clear them, ensuring controlled memory usage. This design promotes efficient memory management in scenarios with potentially large hierarchical data structures.

## Soal7Class

The `Soal7Class` class addresses the issue of improper caching by introducing a mechanism to limit the size of the cache and remove items when the limit is reached. It includes a `Cache` class with methods to add and get items. This caching strategy prevents unbounded memory growth and provides a controlled and efficient caching mechanism.

### Implementation Details

The `Soal7Class` introduces a caching mechanism in the `Cache` class, limiting the size of the cache and removing items when the limit is reached. This design prevents unbounded memory growth and ensures that the cache operates efficiently by maintaining a controlled size. The class includes methods for adding items to the cache (`Add`) and retrieving items from the cache (`Get`).
