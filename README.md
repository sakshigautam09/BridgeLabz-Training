<<<<<<< HEAD
<<<<<<< HEAD
## Day — February 7, 2026
## Topic: Patient Management Module

## Scenarios Implemented
* Implemented patient registration workflow
* Enabled uniqueness validation using phone/email
* Added functionality to update patient information
* Implemented patient search by ID, phone, and name
* Enabled viewing of patient visit history

## Key Concepts Applied
* SQL INSERT and UPDATE operations
* Search using LIKE and exact match queries
* Primary key and auto-increment handling
* JOIN queries for visit history retrieval
* ResultSet navigation for displaying data

## Tasks Completed
* Developed UC-1.1 Register New Patient
* Developed UC-1.2 Update Patient Information
* Implemented UC-1.3 Search Patient Records
* Implemented UC-1.4 View Patient Visit History
* Strengthened understanding of patient data management and relational queries

<!-- ------------------------------------------------------ -->
## Day — February 8, 2026
## Topic: Doctor Management Module

## Scenarios Implemented
* Added doctor profile creation functionality
* Enabled specialty assignment and updates
* Implemented viewing doctors by specialty
* Enabled soft deletion/deactivation of doctor profiles

## Key Concepts Applied
* Foreign key relationships
* Transaction handling for data integrity
* JOIN queries for specialty mapping
* Nested SELECT queries for validation
* Soft delete using UPDATE statements

## Tasks Completed
* Implemented UC-2.1 Add Doctor Profile
* Implemented UC-2.2 Assign/Update Doctor Specialty
* Developed UC-2.3 View Doctors by Specialty
* Implemented UC-2.4 Deactivate Doctor Profile
* Strengthened understanding of doctor data and referential integrity
<!-- ---------------------------------------------------------- -->
## Day — February 9, 2026
## Topic: Appointment Scheduling System

## Scenarios Implemented
* Implemented appointment booking functionality
* Enabled doctor availability checking
* Added appointment cancellation workflow
* Implemented appointment rescheduling logic
* Created daily appointment schedule view

## Key Concepts Applied
* PreparedStatement usage for secure queries
* Transactions for appointment operations
* GROUP BY and COUNT for slot availability
* Multi-table JOIN queries
* ORDER BY for schedule sorting

## Tasks Completed
* Implemented UC-3.1 Book New Appointment
* Developed UC-3.2 Check Doctor Availability
* Implemented UC-3.3 Cancel Appointment
* Implemented UC-3.4 Reschedule Appointment
* Developed UC-3.5 View Daily Appointment Schedule
* Strengthened understanding of scheduling logic and transaction handling

<!-- ------------------------------------------------------------- -->
## Day — February 10, 2026
## Topic: Visit Management & Medical Records

## Scenarios Implemented
* Implemented patient visit recording after appointments
* Enabled viewing of patient medical history
* Added prescription recording functionality

## Key Concepts Applied
* Transaction management for visit and appointment updates
* One-to-many relationships (visits and prescriptions)
* JOIN queries across multiple medical tables
* Batch INSERT operations
* Chronological data ordering

## Tasks Completed
* Implemented UC-4.1 Record Patient Visit
* Developed UC-4.2 View Patient Medical History
* Implemented UC-4.3 Add Prescription Details
* Strengthened understanding of medical record management and data consistency

<!-- ---------------------------------------------------------- -->
## Day — February 11, 2026
## Topic: Billing & Payment Module

## Scenarios Implemented
* Implemented bill generation for patient visits
* Added payment recording functionality
* Enabled viewing outstanding bills
* Generated revenue reports

## Key Concepts Applied
* Aggregate functions (SUM, COUNT)
* Foreign key mapping with visits and patients
* Transaction handling for payments
* Reporting queries using GROUP BY and HAVING
* Date range filtering using BETWEEN

## Tasks Completed
* Implemented UC-5.1 Generate Bill for Visit
* Developed UC-5.2 Record Payment
* Implemented UC-5.3 View Outstanding Bills
* Developed UC-5.4 Generate Revenue Report
* Strengthened understanding of financial data handling and reporting

<!-- ------------------------------------------------------------- -->
## Day — February 12, 2026
## Topic: System Administration & Database Operations

## Scenarios Implemented
* Managed specialty lookup reference data
* Implemented database backup workflow
* Enabled viewing system audit logs

## Key Concepts Applied
* CRUD operations on reference tables
* Foreign key constraint validation
* DatabaseMetaData usage
* Trigger-based audit logging
* Complex WHERE conditions and subqueries

## Tasks Completed
* Implemented UC-6.1 Manage Specialty Lookup
* Developed UC-6.2 Database Backup Trigger process
* Implemented UC-6.3 View System Audit Logs
* Strengthened understanding of database administration and monitoring
<!-- ----------------------------------------------------------------- -->
## Day — February 13, 2026
## Topic: Email Validator – College Admission Portal

## Scenarios Implemented
* Developed backend module for email validation in student registration system
* Accepted user email inputs during admission process
* Implemented regex-based validation to verify correct email format
* Handled invalid inputs and exceptions during validation
* Ensured duplicate and malformed email entries are prevented

## Key Concepts Applied
* Regular Expressions (Regex) for pattern validation
* Pattern and Matcher usage
* Exception handling for invalid input cases
* Multithreading concepts for responsive validation flow
* IO file handling for storing and verifying email data
* Annotation-based validation with regex rules
* Modular method design for reusable validation logic

## Tasks Completed
* Designed email validation module using C#
* Implemented regex pattern for standard email format
* Validated usernames with alphanumeric characters, dots, and underscores
* Verified domain and extension formats (.com, .in, .org, .edu, etc.)
* Tested module with valid and invalid email scenarios
* Handled errors using structured exception handling
* Strengthened understanding of regex validation and backend input processing

<!-- ------------------------------------------------------------------ -->
## Day — February 14, 2026
## Topic: NotifyHub – Concurrent Notification Processing System

## Scenarios Implemented
* Designed a notification processing system to handle email, SMS, and app alerts
* Implemented concurrent intake of notifications into in-memory collections
* Enabled asynchronous and multithreaded notification sending
* Prioritized notifications based on priority levels
* Ensured failures in one notification do not affect others
* Applied validation rules using annotations/attributes within notification model

## Key Concepts Applied
* Object-Oriented Programming (encapsulation, inheritance, polymorphism, abstraction)
* Collections framework for managing notification queues
* Multithreading for parallel notification processing
* Asynchronous programming using async/await and tasks
* Annotation/attribute-based validation for notification data rules
* Concurrency and synchronization for safe status updates
* Exception handling for runtime and delivery failures
* Dynamic selection of sending logic based on notification type

## Tasks Completed
* Designed notification entity with ID, recipient, message, priority, and timestamp
* Implemented validation rules for notification data using attributes
* Created in-memory notification holding and prioritization mechanism
* Developed concurrent processing logic for sending notifications
* Implemented dynamic delivery strategies for multiple notification types
* Added failure handling and status tracking for each notification
* Ensured system scalability and responsiveness under high notification load
* Strengthened understanding of concurrent system design and asynchronous processing

<!-- --------------------------------------------------------------------- -->
## Day — February 16, 2026
## Topic: Bank Transaction Processing System

## Scenarios Implemented
* Designed bank transaction processor to handle high-volume operations
* Created SQL tables for Accounts and Transactions
* Implemented transaction insertion and account balance updates
* Simulated parallel withdrawals on the same account
* Prevented race conditions during concurrent processing
* Implemented rollback mechanisms for failure scenarios

## Key Concepts Applied
* Database transaction management for atomicity
* Concurrency handling in financial operations
* Multithreading for parallel withdrawal simulation
* In-memory caching using Dictionary<int, Account>
* Exception handling for insufficient balance scenarios
* Data consistency and rollback strategies
* Unit testing for concurrent and failure cases

## Tasks Completed
* Created Accounts and Transactions database tables
* Implemented transaction insert operations
* Updated account balance securely during withdrawals
* Simulated 50 concurrent withdrawals on a single account
* Implemented synchronization to prevent race conditions
* Maintained in-memory account cache using dictionary structure
* Tested insufficient balance handling
* Tested concurrent withdrawal processing
* Implemented rollback logic on transaction failure
* Strengthened understanding of transaction processing and concurrency control

<!-- ------------------------------------------------------------- -->
## Day — February 17, 2026
## Project: TechVille Smart City Management System
## Topic: Modules 1, 2 & 3 Implementation

## Scenarios Implemented
* Developed Citizen Registration Portal for capturing citizen details
* Implemented service eligibility calculation based on age, income, and residency
* Built Service Eligibility Checker using decision-making and iteration logic
* Enabled multi-member registration using loops
* Organized citizen data using arrays for efficient storage and retrieval
* Structured zone-wise and sector-wise citizen data representation

## Key Concepts Applied
* Variables, literals, primitive data types, and basic I/O operations
* Arithmetic, comparison, and logical operators
* Conditional statements (if-else, switch, ternary)
* Iteration constructs (for, while, do-while, for-each)
* Arrays (single and multi-dimensional)
* Array operations: searching, sorting, copying
* Memory management concepts and role of JVM & garbage collection

## Tasks Completed
* Implemented Module 1: Citizen Registration Portal
* Implemented Module 2: Service Eligibility Checker
* Implemented Module 3: Smart Citizen Database
* Created eligibility calculation logic
* Built loops for registering multiple citizens
* Stored and managed citizen data using arrays
* Strengthened understanding of programming basics, logic building, and memory handling

<!-- ---------------------------------------------------------- -->
## Day — February 18, 2026
## Project: TechVille Smart City Management System
## Topic: Modules 4, 5 & 6 Implementation

## Scenarios Implemented
* Built Citizen Profile Management system with reusable string utilities
* Implemented validation, search, and update functionalities for citizen profiles
* Developed robust error-handling mechanisms for registration system
* Designed object-oriented structure for city services framework
* Created service-specific modules for healthcare, education, and transportation

## Key Concepts Applied
* String manipulation and reusable methods
* Functions and modular programming
* Pass by value and pass by reference concepts
* Exception handling with try-catch-finally
* Custom exception creation and logging mechanisms
* OOP fundamentals: classes, objects, constructors, access modifiers
* Encapsulation and instance vs class variables

## Tasks Completed
* Implemented Module 4: Citizen Profile Management
* Implemented Module 5: Robust Registration System
* Implemented Module 6: City Services Framework
* Created string utility and validation methods
* Added exception handling and logging mechanisms
* Designed Citizen and Service classes with proper encapsulation
* Implemented specialized service classes
* Strengthened understanding of OOP design, modular programming, and error handling

<!-- ------------------------------------------------------------ -->
## Day — February 19, 2026
## Topic: SonarQube Integration in Address Book

## Scenarios Implemented
* Integrated SonarQube for static code analysis in Address Book project
* Configured project settings and scanning workflow
* Performed initial code quality analysis
* Reviewed detected bugs, vulnerabilities, and code smells
* Prepared project for continuous quality monitoring

## Key Concepts Applied
* Static code analysis for improving software quality
* Code smell detection and bug identification
* Quality gates and code standards enforcement
* Maintainability and technical debt monitoring
* Integration of analysis tools into development workflow

## Tasks Completed
* Installed and configured SonarQube
* Connected Address Book project with SonarQube scanner
* Executed first project scan
* Analyzed reports generated by SonarQube
* Identified improvement areas in codebase
* Strengthened understanding of automated code quality practices

<!-- ---------------------------------------------------------- -->
## Day — February 19, 2026
## Topic: MSTest Integration in Address Book

## Scenarios Implemented
* Added MSTest framework to Address Book project
* Created unit testing project structure
* Developed test cases for core functionalities
* Executed tests for validation and logic verification
* Established base for automated testing workflow

## Key Concepts Applied
* Unit testing principles
* Test case design and validation
* Automated test execution
* Software reliability through testing
* Foundation for test-driven development

## Tasks Completed
* Installed and configured MSTest framework
* Created and linked test project to main Address Book solution
* Wrote unit tests for contact creation, update, and deletion
* Executed and verified test results
* Improved confidence in application functionality
* Strengthened understanding of software testing practices

<!-- ----------------------------------------------------- -->
## Day — February 17, 2026
## Topic: UC-17 & UC-18 Implementation in Address Book

## Scenarios Implemented
* Implemented non-blocking I/O operations during CRUD activities
* Enabled asynchronous handling for CSV File, JSON File, and JSON Server data sources
* Ensured main thread remains responsive while performing file and server operations
* Added database storage capability for Address Book
* Extended system to support new data sources without modifying existing logic

## Key Concepts Applied
* Asynchronous programming for non-blocking I/O operations
* CRUD operations across multiple data sources
* Open–Closed Principle (OCP) for scalable system design
* Data persistence using database integration
* Modular architecture for adding new data sources

## Tasks Completed
* Implemented UC-17 for asynchronous CRUD operations on CSV, JSON, and JSON Server
* Ensured main application thread is not blocked during I/O processes
* Implemented UC-18 for saving Address Book data into Database
* Designed system to allow addition of new data sources without modifying existing code
* Verified OCP compliance while integrating database and server sources
* Tested functionality across all data sources
* Strengthened understanding of scalable architecture and asynchronous processing

## Day — January 21, 2026
## Topic: Collections in C#

## Scenarios Implemented
## List Operations:
    * Reversing a List without built-in methods
    * Rotating elements by given positions
    * Removing duplicates while preserving order
    * Finding the Nth element from the end
    * Counting frequency of elements using Dictionary

## Set Operations:
    * Comparing two sets for equality
    * Finding Union, Intersection, and Symmetric Difference
    * Converting a set to a sorted list without using built-in sort
    * Checking subset relationships

## Map/Dictionary Operations:
    * Counting word frequencies in a text
    * Inverting a Dictionary<K,V> to Dictionary<V,List<K>>

## Key Concepts Applied
    * Generics and type-safe collections (List<T>, HashSet<T>, Dictionary<K,V>)
    * Manual iteration and element manipulation
    * Stability and order preservation in lists
    * Non-comparison based sorting and set operations
    * Modular, scenario-based DSA implementation

## Tasks Completed
    * Implemented all required List, Set, and Map operations manually
    * Reinforced understanding of generics in C#
    * Practiced writing modular and reusable code
    * Tested scenarios to ensure correctness and stability

<!-- ------------------------------------------------------------- -->
## Day — January 22, 2026
## Topic: C# Streams & Rank Sheet Generator

## Morning Session: C# Streams
## Scenarios Implemented
    * Reading large files efficiently using StreamReader
    * Writing data to files using StreamWriter
    * Copying files using FileStream and BufferedStream
    * Filtering stream data (uppercase to lowercase conversion)
    * Binary data handling using BinaryReader and BinaryWriter
    * In-memory data processing using MemoryStream
    * Inter-thread communication using PipeStreams
    * Exception-safe stream handling

## Key Concepts Applied
    * Stream-based I/O vs memory-based processing
    * Buffered vs unbuffered streams (performance impact)
    * Text vs binary streams
    * Character encoding handling (UTF-8)
    * Resource management and safe closing of streams
    * Sequential, efficient file processing for large data

## Afternoon Session: Rank Sheet Generator (C# Application)
## Scenarios Implemented
    * Storing student records (roll no, name, marks)
    * Calculating total marks and percentage
    * Generating rank list based on scores
    * Handling tie cases logically
    * Sorting student data manually without built-in sorting helpers
    * Displaying formatted rank sheet in console
    * Writing rank sheet output to a file

## Key Concepts Applied
    * Collections (List<T>, Dictionary<TKey,TValue>)
    * Manual sorting and comparison logic
    * Data aggregation and computation
    * Separation of data processing and display logic
    * Real-world application of collections and streams

## Tasks Completed
    * Implemented multiple stream-based file operations
    * Compared buffered and unbuffered stream performance
    * Built an end-to-end rank sheet generator
    * Reinforced practical usage of collections with streams
    * Practiced writing efficient, readable, and modular C# code

<!-- ----------------------------------------------------- -->
## Day — January 23, 2026
## Topic: Validation, Testing & Runtime Inspection

## Morning Session: Regex & NUnit Testing
## Scenarios Implemented
    * Created simple regex patterns for validation (password, username)
    * Validated strings using character classes and quantifiers
    * Wrote unit tests using NUnit
    * Tested string utility methods (reverse, palindrome, case conversion)
    * Understood compile-time vs runtime errors through examples

## Key Concepts Applied
    * Regular expressions (basic patterns, character classes)
    * NUnit testing framework
    * Unit testing principles (arrange, act, assert)
    * Test case design for edge cases
    * Difference between errors and exceptions

## Tasks Completed
    * Built regex-based validation programs
    * Wrote and executed NUnit test cases
    * Practiced debugging using test failures

## Afternoon Session: Annotations & Reflection
## Scenarios Implemented
    * Created custom annotations (attributes)
    * Applied annotations to classes and methods
    * Used Reflection to read annotation metadata at runtime
    * Retrieved method information using MethodInfo
    * Executed logic based on annotation presence

## Key Concepts Applied
    * Custom attributes in C#
    * Reflection (Type, MethodInfo, GetCustomAttributes)
    * Runtime metadata inspection
    * Attribute-driven behavior

## Tasks Completed
    * Implemented annotation-based feature flags
    * Retrieved and processed metadata dynamically
    * Strengthened understanding of runtime behavior in C#

<!-- ----------------------------------------------------- -->
## Day — January 27, 2026
## Topic: Reflection, Annotations & Metadata Processing

## Morning Session: API Metadata Validator (HealthCheckPro)
## Scenarios Implemented
    * Created custom annotations for API methods (@PublicAPI, @RequiresAuth)
    * Scanned controller classes using Reflection
    * Validated presence of required annotations on API methods
    * Identified missing metadata in controller methods
    * Auto-generated simple API documentation

## Key Concepts Applied
    * Custom annotations (attributes)
    * Reflection for scanning classes and methods
    * Method metadata inspection
    * Separation of concerns (annotations, scanner, validator)
    * Basic documentation generation logic

## Tasks Completed
    * Built annotation-based API validation utility
    * Ensured consistency of API method metadata
    * Generated structured API documentation automatically

## Afternoon Session: Auto Audit System (EventTracker)
## Scenarios Implemented
    * Created custom @AuditTrail annotation for tracking events
    * Used Reflection to scan classes and detect audited methods
    * Generated structured JSON logs for user actions
    * Captured timestamps and metadata for each audited event

## Key Concepts Applied
    * Custom annotations with metadata
    * Reflection-based method scanning
    * JSON structure generation
    * Event logging and audit trail concepts

## Tasks Completed
    * Implemented automatic audit logging system
    * Generated structured JSON logs for enterprise events
    * Practiced combining annotations, reflection, and logging 

<!-- -------------------------------------------------------------- -->
## Day — January 28, 2026
## Topic: Scenario-Based Application Logic & Validations

## Morning Session: Aero Vigil
## Scenarios Implemented
    * Managing aircraft surveillance records
    * Tracking flight identifiers and patrol zones
    * Monitoring altitude and speed compliance
    * Identifying suspicious or unauthorized aircraft
    * Generating alert reports based on rule violations
    * Searching aircraft details using unique IDs

## Key Concepts Applied
    * Object-oriented design (classes, constructors, encapsulation)
    * Collections: List<T>, Dictionary<TKey, TValue>
    * Conditional validation logic
    * String parsing and numeric comparisons
    * Separation of surveillance logic into utility methods

## Tasks Completed
    * Designed an air-surveillance workflow using OOP
    * Implemented rule-based aircraft monitoring
    * Built reusable methods for tracking and alerts
    * Strengthened logical thinking with real-world defense scenarios

## Afternoon Session: Bank Account Validations
## Scenarios Implemented
    * Creating bank accounts with initial balance
    * Validating deposit operations
    * Handling negative deposit scenarios
    * Validating withdrawal limits
    * Detecting insufficient balance conditions
    * Exception handling with meaningful messages

## Key Concepts Applied
    * Encapsulation using properties
    * Constructor-based initialization
    * Business rule validation using conditions
    * Exception handling (throw, try-catch)
    * Unit-test-friendly method design

## Tasks Completed
    * Implemented secure banking logic
    * Enforced strict validation rules
    * Practiced exception-driven error handling
    * Reinforced real-world financial validation scenarios in C#

<!-- ------------------------------------------------------------- -->
## Day — January 29, 2026
## Topic: C# Collection-Based Applications

## Morning Session: StreamBuzz – Creator Engagement Tracker
## Scenarios Implemented
    * Registered creators with weekly like counts (4 weeks)
    * Stored creator engagement data using collections
    * Identified top-performing creators based on a like threshold
    * Counted weeks meeting the engagement threshold
    * Calculated overall average weekly likes

## Key Concepts Applied
    * Collections: List<T>, Dictionary<TKey, TValue>
    * Object-oriented programming (classes, properties)
    * Aggregation and counting logic
    * Menu-driven console application design

## Tasks Completed
    * Built a creator engagement tracking system
    * Implemented threshold-based performance analysis
    * Calculated global engagement averages

## Afternoon Session: OceanFleet – Vessel Performance Analytics
## Scenarios Implemented
    * Added vessel performance details to a collection
    * Retrieved vessel information using vessel ID
    * Identified vessels with the highest average speed
    * Handled multiple vessels sharing the same top performance

## Key Concepts Applied
    * Model and utility class separation
    * Collection traversal and searching
    * Comparison and filtering logic
    * Clean object-oriented design

## Tasks Completed
    * Developed a vessel analytics system
    * Implemented search and high-performance detection
    * Strengthened practical use of collections and OOP

<!-- ------------------------------------------------------------- -->
## Day — January 30, 2026
## Topic: Scenario based -> Lexical Twist & Future Logistics

## Morning Session: Lexical Twist
## Scenarios Implemented
    * Tokenizing input strings using delimiters
    * Word frequency counting
    * Case-insensitive text processing
    * Removing stop-words from sentences
    * Detecting palindromes and anagrams
    * Basic string pattern validation

## Key Concepts Applied
    * String methods (Split, ToLower, Trim)
    * Collections: Dictionary<string, int>, List<string>
    * Loops and conditional logic
    * Basic validation without complex regex
    * Clean separation of logic into methods

## Tasks Completed
    * Processed textual input efficiently
    * Practiced lexical analysis basics
    * Strengthened string handling fundamentals in C#
    * Improved logical thinking using text problems

## Afternoon Session: Future Logistics
## Scenarios Implemented
    * Managing shipment records
    * Route-wise cargo tracking
    * Capacity validation for transport vehicles
    * Delivery status updates
    * Identifying high-priority shipments

## Key Concepts Applied
    * Object-oriented design (classes, objects, constructors)
    * Collections: List<T>
    * Data validation using conditions
    * Simple aggregation logic (count, max, filter)
    * Console-based menu-driven application design

## Tasks Completed
    * Designed logistics workflow using OOP
    * Implemented validation rules for shipments
    * Built reusable business-logic methods
    * Reinforced real-world problem solving using C#

<!-- ------------------------------------------------------- -->
## Day — February 2, 2026
## Topic: Code Quality Analysis & String Transformation Logic

## Morning Session: Applied SonarQube on Aero Vigil
## Scenarios Implemented
    * Integrated SonarQube with the Aero Vigil project
    * Performed static code analysis
    * Identified code smells, bugs, and security hotspots
    * Analyzed duplication and complexity issues
    * Reviewed maintainability and reliability ratings

## Key Concepts Applied
    * Static code analysis fundamentals
    * Clean Code principles
    * Code quality metrics (bugs, vulnerabilities, code smells)
    * Refactoring based on SonarQube feedback
    * Improving readability and maintainability

## Tasks Completed
    * Improved overall code quality of Aero Vigil
    * Reduced code smells through refactoring
    * Gained hands-on experience with SonarQube reports
    * Strengthened understanding of enterprise-level quality checks

## Afternoon Session: Flip Key
## Scenarios Implemented
    * Input validation based on strict business rules
    * ASCII-based character filtering
    * Case transformation logic
    * String reversal and positional manipulation
    * Error handling using return-based validation

## Key Concepts Applied
    * ASCII value analysis
    * String manipulation techniques
    * Conditional logic and loops
    * Method-based business logic implementation
    * Defensive programming practices

## Tasks Completed
    * Implemented Flip Key transformation logic
    * Practiced real-world string processing scenarios
    * Strengthened problem-solving using character-level logic
    * Improved attention to edge cases and validations

<!-- --------------------------------------------------------- -->
## Day — February 3, 2026
## Topic: Factory Robot Hazard Analyzer & Address Book Enhancements

## Morning Session: Factory Robot Hazard Analyzer
## Scenarios Implemented
    * Developed a hazard analysis system for factory robots
    * Evaluated robot hazard risk based on arm precision, worker density, and machinery state
    * Implemented input validation for all parameters
    * Applied custom exception handling for invalid inputs
    * Calculated hazard risk score using a weighted formula
    * Displayed risk score or error messages depending on nput validity

## Key Concepts Applied
    * Conditional logic for input validation
    * Custom exception creation and handling (RobotSafetyException)
    * Formula-based risk computation
    * Defensive programming practices
    * Ensured robustness against invalid or out-of-range inputs

## Tasks Completed
    * Built a reliable hazard risk calculation module
    * Validated all inputs and enforced constraints strictly
    * Handled error scenarios gracefully using custom exceptions
    * Strengthened understanding of safety-critical programming logic

## Afternoon Session: Address Book — Annotations & Reflection
## Scenarios Implemented
    * Added custom attributes to domain classes (Contact) and interface (IAddressBook)
    * Created a Reflection Inspector to read class metadata, constructors, methods, fields, and annotations at runtime
    * Displayed reflection output at program startup without modifying business logic
    * Verified that all CRUD operations, sorting, and menu interactions remain fully functional

## Key Concepts Applied
    * C# Attributes for metadata annotation
    * Reflection API: Type, GetFields, GetMethods, GetConstructors, GetCustomAttributes
    * Separation of concerns: reflection logic outside core business logic
    * Runtime inspection of private fields and method signatures
    * Maintaining clean code architecture while adding meta-programming

## Tasks Completed
    * Successfully annotated domain and interface classes
    * Built reusable reflection utility for class inspection
    * Verified that existing Address Book functionalities remain intact
    * Gained practical experience with annotations and reflection in enterprise C# applications

<!-- ------------------------------------------------------------ -->
## Day — February 14, 2026
## Topic: Email Validator — College Admission Portal

## Scenarios Implemented
    * Developed an email validation system for a college admission portal
    * Accepted user email input and verified correctness using Regex
    * Implemented strict validation for null, empty, and invalid email formats
    * Applied multithreading to validate multiple email entries efficiently
    * Integrated file handling to store validated emails
    * Generated and maintained a JSON file for persistent storage

## Key Concepts Applied
    * Regex pattern creation and pattern matching
    * Input validation using conditional logic
    * Multithreading for parallel validation processing
    * File I/O operations (read/write)
    * Exception handling for file errors and invalid inputs
    * Defensive programming for reliability

## Tasks Completed
    * Built a complete email validation module
    * Ensured only valid emails are accepted and stored
    * Rejected invalid inputs with clear error messages
    * Stored validated data in a structured JSON file
    * Maintained thread-safe operations during file writing
    * Strengthened understanding of real-world validation and admission-portal workflows

<!-- ------------------------------------------------------------------- -->
## Day — February 17, 2026
## TechVille Smart City Management System

## Overview
TechVille is a smart city project simulation where citizens are registered, evaluated for service eligibility, stored in a database, and managed through profile utilities. This project demonstrates progressive programming concepts through Use Cases (UCs), from basic registration to robust exception handling.

## Modules / Use Cases
    * UC-1: Citizen Registration Portal
    * Topics: Variables, Data Types, Input/Output, Operators
    * Description: Citizens register with personal details (ID, name, age, income, residency).
    * Key Features:
        * Accepts user input for citizen details
        * Calculates eligibility score
        * Basic validation on age

    * UC-2: Service Eligibility Checker
    * Topics: Conditionals (if-else, switch), Loops, Ternary Operators, Break/Continue
    * Description: Determines service packages based on citizen and family member profiles.
    * Key Features:
        * Multi-level eligibility checks
        * Switch statement for package benefits
        * Loops for registering multiple family members
        * Ternary operator for benefit status

    * UC-3: Smart Citizen Database
    * Topics: Arrays (1D & 2D), Array Operations
    * Description: Stores citizen IDs and maintains zone-sector data.
    * Key Features:
        * Add and display citizen IDs
        * Update and display zone-sector citizen counts
        * Array operations: sorting, searching, copying

    * UC-4: Citizen Profile Management
    * Topics: Strings, Functions/Methods, Pass by Value/Reference
    * Description: Manage citizen profiles with reusable utilities.
    * Key Features:
        * Name formatting and email validation
        * Profile search by name
        * Update citizen data via pass-by-value and pass-by-reference
        * Generate complete profiles

    * UC-5: Robust Registration System
    * Topics: Exception Handling, Custom Exceptions
    * Description: Handles invalid inputs and other runtime errors gracefully.
    * Key Features:
        * Try-catch-finally blocks for safe execution
        * Custom exceptions: InvalidAgeException, DuplicateCitizenException
        * Error logging to error_log.txt

## Features Demonstrated
    * Object-Oriented Programming (Classes, Methods, Encapsulation)
    * Arrays and Array Operations
    * Conditional Logic & Loops
    * Exception Handling & Logging
    * Modular Programming
    * User Input Validation
## Day — January 8, 2026
## Topic: Object-Oriented Design & Linked Lists in C#
## Projects: Smart Home Automation System, Linked List–Based Programs

## What I Learned
    * Applied core OOP concepts in a practical system design
    * Understood how abstraction and polymorphism simplify device control
    * Learned when to use different types of linked lists
    * Improved understanding of pointer and reference handling in C#

## Morning Session: Smart Home Automation System
    * Designed appliance classes such as Light, Fan, and AC
    * Used encapsulation to protect internal device states
    * Implemented interfaces to achieve abstraction
    * Applied inheritance for shared appliance behavior
    * Used polymorphism to allow different device responses
    * Understood the importance of a controller for centralized management

## Afternoon Session: Linked Lists in C#
    * Implemented singly linked lists for basic data storage problems
    * Used doubly linked lists for scenarios requiring backward traversal
    * Implemented circular linked lists for continuous processing system
    * Performed insertion, deletion, searching, and traversal operations
    * Avoided collections to strengthen core data structure concepts

## Key Concepts Applied
    * Encapsulation and data hiding
    * Abstraction using interfaces
    * Inheritance for code reuse
    * Polymorphism for dynamic behavior
    * Singly, doubly, and circular linked lists

## Tasks Completed
    * Built a Smart Home Automation system using OOP
    * Implemented multiple linked list programs in C#
    * Tested logic for different edge cases
    * Maintained structured and readable code

<!-- ------------------------------------------------------- -->
## Day — January 9, 2026
## Topic: Linear Data Structures & Real World based problems in C#
## Projects: Linked List Programs, Stack & Queue Problems, Dictionary-Based Logic, ATM Dispenser System

## What I Learned
    * Strengthened understanding of core linear data structures
    * Learned how different data structures solve different real-world problems
    * Understood internal working without using built-in collections
    * Improved problem-solving using constraints and edge cases

## Morning Session: Data Structures in C#
    * Linked Lists
        * Practiced singly linked list operations
        * Implemented insertion, deletion, traversal, and search
        * Understood node-based memory management using references
    * Stack
        * Implemented stack using arrays
        * Applied LIFO principle in practical scenarios
        * Solved stack-based logical problems
    * Queue
        * Implemented queue using arrays
        * Understood FIFO behavior
        * Solved problems like circular tour using queue logic
    * Dictionary (Custom Logic)
        * Implemented key-value based logic
        * Avoided using built-in collections to strengthen fundamentals
        * Understood hashing concept at a logical level

## Afternoon Session: ATM Dispenser System
    * Designed ATM cash dispensing logic
    * Implemented note denomination handling
    * Applied conditional logic for cash availability
    * Handled edge cases like insufficient balance and invalid amounts
    * Simulated real-world ATM behavior using structured code

## Key Concepts Applied
    * Node-based data structures
    * Stack (LIFO) and Queue (FIFO) principles
    * Custom dictionary logic
    * Reference handling in C#
    * Real-world problem modeling

## Tasks Completed
    * Implemented multiple linked list programs
    * Solved stack and queue-based problems
    * Built ATM Dispenser logic from scratch
    * Tested edge cases and constraints
    * Maintained clean, structured, and readable code

<!-- -------------------------------------------------------------- -->
## Day — January 12, 2026
## Topic: Scenario-Based OOP Design problems in C#
## Projects: Metal Factory Pipe Cutting System, LoanBuddy Application, Customer Furniture Manufacturing System

## What I Learned
    * Applied object-oriented design to industrial and business scenarios
    * Strengthened understanding of abstraction and interfaces
    * Learned how polymorphism helps in handling multiple workflows
    * Improved real-world system modeling using OOP principles

## Morning Session: Metal Factory Pipe Cutting System
    * Designed pipe and cutting process models
    * Used abstraction to define cutting operations
    * Implemented interfaces for different cutting strategies
    * Applied inheritance for shared factory behavior
    * Used polymorphism to handle multiple pipe-cutting scenarios
    * Maintained encapsulation to protect internal factory states

## Afternoon Session: LoanBuddy & Furniture Manufacturing System
    * LoanBuddy Application
        * Designed loan processing workflow
        * Used abstract classes for loan applications
        * Implemented interfaces for approval and verification logic
        * Applied polymorphism for different loan types
        * Improved flexibility for future policy changes
    * Customer Furniture Manufacturing System
        * Modeled customer-specific furniture orders
        * Applied inheritance for different furniture types
        * Used encapsulation for order and material details
        * Implemented polymorphic behavior for manufacturing processes

## Key Concepts Applied
    * Encapsulation and data hiding
    * Abstraction using interfaces and abstract classes
    * Inheritance for code reuse
    * Polymorphism for dynamic behavior
    * Real-world manufacturing and finance domain modeling

## Tasks Completed
    * Built Metal Factory Pipe Cutting system
    * Implemented LoanBuddy application logic
    * Designed Furniture Manufacturing system
    * Tested multiple scenarios and edge cases
    * Maintained clean, modular, and readable code

<!-- ------------------------------------------------------ -->
## Day — January 13, 2026
## Topic: Data Handling, String Processing & Searching Algorithms in C#
## Projects: BookBuddy – Digital Bookshelf App, CinemaTime – Movie Schedule Manager, Linear & Binary Search Programs

## What I Learned
    * Strengthened understanding of array-based data management
    * Learned how string manipulation works internally without built-in helpers
    * Improved problem-solving using searching algorithms
    * Applied clean separation of concerns using utility, interface, and main classes

## Morning Session: BookBuddy & CinemaTime Applications
    * BookBuddy – Digital Bookshelf App
        * Designed a digital bookshelf using arrays only
        * Applied encapsulation to protect book details
        * Implemented utility class to handle core logic
        * Used interfaces to achieve loose coupling
        * Sorted books alphabetically using manual string comparison logic
        * Searched books by author using character-by-character matching
        * Avoided built-in string comparison methods to strengthen core logic

    * CinemaTime – Movie Schedule Manager
        * Designed movie scheduling system using arrays
        * Applied encapsulation for movie title and showtime
        * Implemented keyword-based movie search manually (without Contains)
        * Used menu-driven main program for user interaction
        * Separated validation and business logic into utility class
        * Strengthened understanding of substring search logic

## Afternoon Session: Linear & Binary Search
    * Implemented Linear Search for unsorted data
    * Understood step-by-step working of sequential searching
    * Implemented Binary Search on sorted arrays
    * Learned the importance of sorting before applying binary search
    * Compared time complexity of linear vs binary search
    * Practiced dry-run analysis to understand index movement

## Key Concepts Applied
    * Encapsulation and clean class design
    * Interfaces for abstraction and loose coupling
    * Array-based data handling
    * Manual string comparison and substring search
    * Linear Search and Binary Search algorithms
    * Time complexity awareness

## Tasks Completed
    * Built BookBuddy application using arrays only
    * Implemented CinemaTime movie management system
    * Practiced manual string search and sorting logic
    * Implemented and tested Linear and Binary Search programs
    * Maintained readable, modular, and structured code

<!-- --------------------------------------------------------- -->
## Day — January 14, 2026
## Topic: Address Book Application in C#
## Projects: AddressBook – Contact Management

## What I Learned
    * Applied OOP: encapsulation, interfaces, and modular design
    * Managed multiple contacts using arrays
    * Practiced manual string comparison for search and sort
    * Built menu-driven CRUD operations

## Key Concepts Applied
    * Encapsulation & class design
    * Interfaces for abstraction
    * Array-based storage
    * Manual sorting & linear search

## Tasks Completed
    * Added, edited, deleted, and displayed contacts
    * Implemented search by name, city, state, zip
    * Sorted contacts without built-in methods
    * Maintained clean, modular code

<!-- ------------------------------------------------------------ -->
## Day — January 15, 2026
## Topic: BrowserBuddy – Simple Web Browser in C#
## Projects: BrowserBuddy – URL Navigation & History Manager

## What I Learned
    * Built a basic browser interface using console-based menus
    * Applied OOP: encapsulation for URL/history management
    * Practiced array-based history storage and navigation
    * Implemented manual search in browsing history
    * Strengthened modular design with utility and main classes

## Key Concepts Applied
    * Encapsulation & class design
    * Array-based data storage
    * Manual string search for URLs
    * Menu-driven interaction

## Tasks Completed
    * Opened and tracked URLs in history
    * Searched visited URLs manually
    * Navigated forward/backward in history
    * Maintained clean and modular code

<!-- ------------------------------------------------- -->
## Day — January 16, 2026
## Topic: TrafficManager & BookShelf Applications in C#

## Morning Session: TrafficManager
    * Developed a vehicle flow tracking system using arrays
    * Encapsulated vehicle details liketype, count, and timing
    * Applied modular design with utility class separating logic from main program
    * Practiced manual aggregation and reporting without built-in libraries

## Afternoon Session: BookShelf
    * Managed a digital bookshelf using arrays only
    * Encapsulated book details (title, author, publisher) to protect data
    * Implemented manual sorting of books alphabetically and search by author/title
    * Strengthened understanding of array-based data handling and menu-driven interactions
    * Maintained modular, reusable code with utility and main class separation

## Key Concepts Applied
    * Encapsulation and clean OOP design
    * Array-based data handling for both vehicles and books
    * Manual searching and sorting algorithms
    * Menu-driven interaction and separation of concerns

<!-- ------------------------------------------------------ -->
## Day — January 17, 2026
## Topic: FlashDealz & FitnessTracker Applications in C#

## Morning Session: FlashDealz
    * Developed a deals management system using arrays
    * Encapsulated deal details: product name, discount, and validity
    * Implemented menu-driven options to add, view, and search deals
    * Applied manual sorting to display deals by discount or product name
    * Strengthened modularity with a utility class handling all business logic

## Afternoon Session: FitnessTracker
    * Built a step-count tracker for multiple users using arrays
    * Encapsulated user details and daily step counts
    * Implemented menu-driven ranking system to display daily leaderboard
    * Applied bubble sort to sort users by step count manually
    * Practiced real-time updates and manual comparison logic

## Key Concepts Applied
    * Encapsulation and OOP design principles
    * Array-based data handling for multiple entities
    * Manual sorting and searching algorithms
    * Menu-driven interaction and separation of concerns

<!-- ------------------------------------------------------------ -->
## Day — January 20, 2026
## Topic: ParcelTracker & ExamProctor Applications and Generics in C#

## Morning Session: ParcelTracker
    * Developed a parcel tracking system using Singly Linked List
    * Encapsulated parcel stages: Packed → Shipped → In Transit → Delivered
    * Implemented forward tracking and custom intermediate checkpoints
    * Handled lost/missing parcels using null checks
    * Strengthened modularity with a utility class managing parcel operations

## Afternoon Session: ExamProctor
    * Built an online exam review system using Stack, Dictionary, and Generics
    * Tracked question navigation using a generic stack
    * Stored student answers in a generic dictionary (questionID → answer)
    * Implemented scoring logic via functions for automatic evaluation
    * Applied type-safe design using generics for question and answer management

## Key Concepts Applied
    * Encapsulation and OOP design principles
    * Generics for type-safe collections
    * Stack and Dictionary for navigation and storage
    * Function-based scoring logic
    * Separation of concerns and modularity

## Tasks Completed
    * Implemented ParcelTracker
    * Implemented ExamProctor with generics
    * Tested and pushed the code

<!-- ------------------------------------------------- -->
## vDay — January 21, 2026
## Topic: Backtracking & Radix Sort (DSA Scenario-Based)

## Morning Session: Password Cracker Simulator
    * Scenario: Try all combinations to unlock a vault.
    ## Tasks Implemented:
        * Generate all strings of length n (Scenario A)
        * Stop recursion when password is matched (Scenario B)
        * Analyzed time and space complexity (Scenario C)

## Key Concepts:
    * Backtracking and recursion
    * Early pruning for optimization
    * Time complexity: O(kⁿ), Space complexity: O(n)

## Afternoon Session: Aadhar Number Sorting System
    * Scenario: Sort 12-digit Aadhar numbers and search efficiently.
    ## Tasks Implemented:
        * Radix Sort to sort all Aadhar numbers (Scenario A)
        * Binary Search to find a number post-sorting (Scenario B)
        * Maintained order of same-prefix numbers (Scenario C)

## Key Concepts:
    * Radix Sort + Counting Sort for stability
    * Binary Search on sorted arrays
    * Time complexity: O(d*(n+k)), Space complexity: O(n)

## Completed Tasks:
    * Password Cracker Simulator implemented and tested
    * Aadhar Number Sorting System implemented with Radix Sort and Binary Search
    * Verified stability and correctness
    * Analyzed complexity and scenario outcomes

<!-- -------------------------------------------------- -->
## Day — February 2, 2026
## Topic: Applied DSA Concepts — Address Book System

## Address Book Management
## Scenario: Built an Address Book system using basic DSA concepts to store, search, sort, and manage contacts.

## Tasks Implemented:
    * Stored contacts in arrays and tracked count.
    * Added, edited, and deleted contacts.
    * Searched contacts using linear search.
    * Sorted contacts by name, city, state, and zip using bubble sort.
    * Supported multiple address books with unique names and selection.

## Key Concepts Applied:
    * Arrays for storage
    * Linear search for lookup
    * Array shift for deletion
    * Bubble sort for sorting
    * Multi-book handling

## Completed Tasks:
    * Fully functional Address Book with add, edit, delete, search, sort.
    * Multiple address books supported.
    * Verified correctness and stability.
# BridgeLabz-Training
BridgeLabz Training Data

<!-- -------------------------------------------------------- -->
# Day — December 16, 2025 — Git & GitHub Basics
## Topic: Introduction to Git and GitHub
## What I Learned
* Basics of Git and GitHub
* Understanding repositories, commits, and pushes
* How to clone a repository and pull updates

## Task for the Day
* Practice creating a repository on GitHub
* Commit and push sample files
* Explore Git commands such as init, add, commit, and push


## What’s Next
* Organizing projects and codebases for real applications
* Converting code between languages

<!-- ---------------------------------------------------------------- -->
# Day — December 17, 2025 — GitHub Setup & Java Basics
## Topic: GitHub Repository Setup, Folder Structure Organization
## What I Learned
* Setting up a GitHub repository for project tracking
* Creating and organizing folder structures for Java and C# codebases
* Basic Git commands for version control (init, add, commit, push)
* Understanding of Git workflow


## Task for the Day
* Set up project folders for Java and C# codes
* Commit and push initial project files to GitHub

## What’s Next
* Converting Java code to C# and learning branch/folder management

<!-- ------------------------------------------------------------ -->
# Day — December 18, 2025 — Introduction to .NET and C#
## Topic: .NET Framework, C# Syntax, Java to C# Conversion
## What I Learned

## Morning Session:
* Converted Java code to C# and pushed it to GitHub
* Learned how to rename branches and folders in Git
* Strengthened understanding of project structure

## Afternoon Session:
* .NET Architecture: Components, CLR, assemblies, metadata
* IL / MSIL: Understanding intermediate language
* JIT Compiler and managed vs unmanaged code
* C# Basics:
* Console and Console.WriteLine
* Using System namespace
* Taking user input via Console.ReadLine
* Java to C# Conversion Details:
* Key differences between Java and C# (e.g., Main method, using statements, Console I/O)
* Handling syntax changes while converting Java programs to C# equivalents
* Building and running C# programs

## Task for the Day
* Convert Java code to C#
* Push C# code to GitHub
* Practice C# console input/output operations
* Learn IL, MSIL, and .NET execution flow

<!-- -------------------------------------------------------------- -->
# Day — December 19, 2025 — Introduction to Datatypes and Opeartors in C#
## Topic: .Net Achitecture, Compiler Explanation, Datatypes & Operators, Memory usage, Access modifiers
## What I Learned

## Morning Session:
* Introduction to C# datatypes
  * Value types (int, float, double, char, bool, etc.)
* Understanding implicit and explicit type conversion
* Operators in C#:
  * Arithmetic operators
  * Relational (comparison) operators
  * Logical operators
  * Assignment operators
  * Unary operators
  * Bitwise operators
  * Ternary operator
  * Type operators (`is`, `typeof`, `as`)
* Writing a single C# program demonstrating all datatypes and operators
* Understanding how `Console.WriteLine()` works with different datatypes

## Afternoon Session:
* Memory Usage:
  * Value types - stack memory
  * Reference types - heap memory
* Access Modifiers in C#
  * public
  * private
  * protected
  * internal
  * protected internal
  * private protected
* Basic Programs Practiced:
  * Quotient and Remainder
  * IntOperation & DoubleOperation
  * Temperature Conversion (Celsius ↔ Fahrenheit)
  * Total Income Calculation
  * Swap Two Numbers
  * Trip Distance Calculation

## Task for the Day
* Practice C# datatypes with examples
* Implement all operators in a single C# program
* Understand implicit vs explicit type conversion
* Learn about all the access modifiers
* Practice programs provided in the assessment
* Push updated code to GitHub

<!-- ------------------------------------------------------------------- -->
# Day — December 22, 2025 — Introduction to Control Flow Statements in C#
## Topic: Control Flow Statements (Decision Making & Looping)
## What I Learned
## Morning Session:
* Introduction to control flow statements in C#
  * Understanding the importance of control flow in program execution
  * Conditional Statements:
  * if statement
  * if-else statement
  * else-if ladder
  * Nested if statements
* Looping Statements:
  * for loop
  * Initialization, condition, increment/decrement
  * while loop
  * Entry-controlled loop
  * do-while loop
  * Exit-controlled loop
  * Difference between while and do-while
  * foreach loop
* Selection Statement:
 * switch-case
 * Use of break
 * Default case
* Flow control keywords:
  * break
  * continue

## Afternoon Session:
  * Hands-on practice with control flow programs
  * Writing programs using:
  * Conditional logic
  * Loop-based iteration
  * Understanding real-world use cases of:
  * if-else vs switch-case
  * for vs while vs do-while
* Practiced programs
* Debugging common mistakes in loops and conditions
* Improving logical thinking using control flow

## Task for the Day
  * Practice all conditional statements with examples
  * Write programs using: if-else, switch-case
  * Practice all looping statements: for, while, do-while, foreach
  * Understand differences between loop types
  * Solve assessment programs using control flow
  * Push updated practice code to GitHub


<!-- --------------------------------------------------------------------- -->
# Day — December 23, 2025 — Introduction to Arrays in C#
## Topic: Arrays (1D, 2D, and Multi-Dimensional Arrays)
## What I Learned
## Morning Session:
  * Introduction to Arrays in C#
  * Understanding the need for arrays to store multiple values of the same data type
  * Array declaration, initialization, and usage
  * Types of Arrays:
    * One-Dimensional Arrays
    * Two-Dimensional Arrays
    * Jagged Arrays (Array of Arrays)
  * Accessing array elements using index
  * Iterating through arrays using: 
    * for loop
    * foreach loop
  * Understanding array length and index boundaries
  * Common mistakes while working with arrays (index out of range)

## Afternoon Session:
* Hands-on practice with array-based programs
* Storing and processing user input using arrays
* Programs practiced using arrays
* Input validation while storing values in arrays
* Using index decrement to re-enter invalid input
* Understanding memory allocation for array

## Task for the Day
* Practice creating and using:
  * One-dimensional arrays
  * Two-dimensional arrays
  * Jagged arrays
* Write programs to perform calculations using arrays
* Practice array traversal using loops
* Solve assessment programs based on arrays
* Improve logic building using array manipulation
* Push updated array-based programs to GitHub


<!-- -------------------------------------------------------------------- -->
# Day — December 24, 2025 — Methods in C#
## Topic: Using Methods for Modular Programming and Logic Building
## What I Learned
## Morning Session:
  * Introduction to methods in C#
  * Understanding the need for methods in program design
  * Method declaration, definition, and calling
  * Passing parameters to methods
  * Returning values from methods
  * Improving code readability and reusability using methods

## Afternoon Session:
  * Hands-on practice with method-based programs
  * Writing separate methods for calculations and logic
  * Calling methods from the Main method
  * Understanding parameter passing and return types
  * Debugging logical errors in method-based programs

## Programs Practiced
  * Level-1 (Method-Based Programs):
      * Check Number
      * Chocolate Distribution
      * Maximum Number of Handshakes
      * Quotient and Remainder

## Key Concepts Covered:
  * Method-based program structure
  * Parameter passing
  * Return values
  * Code reusability
  * Logical separation of tasks
  * Modular programming approach

## Task for the Day
  * Practice writing reusable methods
  * Improve program modularity
  * Strengthen logical thinking using methods
  * Refactor code for better readability
  * Test programs with different inputs
  * Push updated method-based programs to GitHub

<!-- ---------------------------------------------------------------------- -->
# Day — December 25, 2025 — Method-Based Programs in C#
## Topic: Intermediate and Advanced Logic Using Methods
## What I Learned
  * Strengthened understanding of method-based program design
  * Applied methods to solve real-world and mathematical problems
  * Broke complex problems into smaller reusable methods
  * Improved logical thinking using conditions and loops
  * Worked on multi-step calculations and validations
  * Enhanced code readability through modular structure

## Key Concepts Covered
  * Method reusability and modular programming
  * Conditional logic and loops
  * Mathematical and logical computations
  * Multi-parameter methods
  * Input validation

Problem-solving using structured approach

## Task for the Day
  * Practice intermediate and advanced method-based problems
  * Improve logical accuracy and efficiency
  * Refactor code for better readability
  * Test programs with different input values
  * Push updated programs to GitHub


<!-- ------------------------------------------------------------------ -->
# Day — December 26, 2025 — Strings and Exceptions in C#
## Topic: String Handling and Common Exceptions in C#
## What I Learned
## Morning Session:
  * Introduction to strings in C#
  * Understanding string as a reference type
  * Difference between string and String
  * String immutability and its impact on performance
  * String declaration and initialization
  * Accessing characters in a string using index
  * String length and indexing boundaries
  * Introduction to exceptions in C#
  * Understanding why exceptions occur at runtime

## Afternoon Session:
  * Hands-on practice with string-based programs
  * Performing string manipulation without using built-in methods
  * Using loops to traverse strings
  * Reversing a string using logic
  * Checking palindrome strings
  * Counting characters, words, and vowels in a string
  * Writing programs to intentionally generate exceptions
  * Observing program behavior during runtime errors

## Exceptions Practiced:
  * NullReferenceException
  * IndexOutOfRangeException
  * FormatException

## Key Concepts Covered:
  * String immutability
  * Index-based access
  * Loop-based string traversal
  * Common runtime exceptions
  * Causes of exceptions in real programs
  * Importance of writing safer code

## Task for the Day
  * Practice string manipulation programs
  * Write code to understand common exceptions
  * Identify causes of runtime errors
  * Improve code safety through better logic
  * Refactor code to avoid common exceptions
  * Push updated string and exception-based programs to GitHub

<!-- -------------------------------------------------------------------- -->
# Day — December 27, 2025 — Extra String Programs in C#
## Topic: Advanced String Manipulation and Logic Building
## What I Learned
## Morning Session:
  * Revision of basic string concepts in C#
  * Understanding problem statements related to strings
  * Breaking string problems into logical steps
  * Identifying patterns in string manipulation problems
  * Improving logical thinking using character-level operations

## Afternoon Session:
  * Hands-on practice with additional string-based programs
  * Implementing string logic without relying heavily on built-in methods
  * Using loops and conditional statements for string processing
  * Improving accuracy in string comparison and validation
  * Debugging logical errors in string programs

## Programs Practiced:
Anagram Strings
Compare Strings
Count Vowels and Consonants
Find Substring Occurrences
Longest Word in a String

## Key Concepts Covered:
  * Character-by-character string traversal
  * ASCII and character comparisons
  * Loop-based string manipulation
  * Conditional logic for string operations
  * String validation techniques
  * Efficient logic building for text processing

## Task for the Day
  * Practice advanced string problems
  * Improve problem-solving speed
  * Strengthen understanding of string logic
  * Refactor programs for better readability
  * Handle edge cases in string inputs
  * Push updated string programs to GitHub


<!-- -------------------------------------------------------------------- -->
# Day — December 28, 2025 — Built-in Methods and Logic-Based Programs in C#
## Topic: Using Built-in Methods and Strengthening Core Logic
## What I Learned
## Morning Session:
  * Understanding and using built-in methods provided by C#
  * Applying built-in methods for calculations, comparisons, and formatting
  * Working with predefined classes and their methods
  * Understanding method behavior through practical examples
  * Combining built-in methods with conditional logic

## Afternoon Session:
  * Hands-on practice with logic-based programs
  * Using built-in methods to simplify program logic
  * Strengthening problem-solving skills using conditions and loops
  * Writing clean and modular code
  * Handling user input and validating results

## Programs Practiced
  * Level-1 (Built-in Methods):
      * Date Arithmetic
      * Date Comparison
      * Date Formatting
      * Time Zones

  * Level-2 (Logic & Calculations):
      * Basic Calculator
      * Factorial
      * Fibonacci Sequence
      * GCD and LCM


## Key Concepts Covered:
  * Usage of built-in methods
  * Logical operations and comparisons
  * Loop-based calculations
  * Conditional statements
  * Mathematical problem solving
  * Modular programming approach

## Task for the Day
  * Practice programs using built-in methods
  * Improve understanding of method usage
  * Strengthen logical thinking
  * Refactor programs for better readability
  * Handle edge cases effectively
  * Push updated programs to GitHub


<!-- ------------------------------------------------------------------ -->
# Day — December 29, 2025 — Scenario-Based Programming in C#
## Topic: Scenario-Based Problems, Logic Building, and Problem Solving
## What I Learned
## Morning Session:
  * Introduction to scenario-based programming problems
  * Understanding problem statements and breaking them into smaller logical steps
  * Identifying inputs, outputs, and constraints in real-world scenarios
  * Applying conditional statements and loops effectively
  * Designing logic before writing code
  * Importance of dry run and test cases
  * Improving problem-solving approach using step-by-step execution

## Afternoon Session:
  * Hands-on practice with scenario-based programs
  * Implementing logic-heavy programs using arrays, strings, and control structures
  * Debugging logical errors and handling edge cases
  * Writing clean and readable code
  * Understanding real-world problem simulation through code

## Programs Practiced:
  * Snake and Ladder game simulation
  * String Formatter program
  * Temperature Analyzer program

## Key Concepts Applied:
  * Arrays and multi-dimensional arrays
  * Loops (for, while, foreach)
  * Conditional statements (if-else, switch)
  * String manipulation
  * Input validation
  * Modular programming using methods
  * Index handling and boundary checks

## Task for the Day
  * Practice solving scenario-based problems
  * Improve logical thinking and analytical skills
  * Implement real-world simulations using C#
  * Debug and optimize existing programs
  * Refactor code for better readability
  * Push updated scenario-based programs to GitHub

<!-- --------------------------------------------------------- -->
# Day — December 30, 2025 — Scenario-Based Programming in C#
## Topic: Menu-Driven Applications and Real-World Simulations
## What I Learned
## Morning Session:
  * Design and implementation of Library Management System (LMS)
  * Understanding real-world roles: Admin (Librarian) and User
  * Implementing secure role separation using basic passcode logic
  * Storing and managing book data using arrays
  * Performing add, remove, update operations (Admin only)
  * Implementing search, view, checkout, and return functionalities (User)
  * Handling dynamic data using array resizing
  * Using case-insensitive string comparison
  * Designing menu-driven programs using while loops
  * Writing modular and reusable methods

## Afternoon Session:
  * Design and implementation of EduQuiz – Student Quiz Grader
  * Using arrays to store correct answers and student responses
  * Implementing quiz evaluation logic using methods
  * Applying case-insensitive string comparison for answer validation
  * Printing detailed per-question feedback
  * Calculating total score and percentage
  * Displaying pass/fail result based on evaluation criteria
  * Designing menu-driven quiz applications
  * Improving logical thinking and flow control

## Key Concepts Applied:
  * Single-dimensional arrays
  * Dynamic array resizing
  * Menu-driven programming
  * Role-based access control (basic passcode approach)
  * Case-insensitive string comparison
  * Loops (for, while)
  * Conditional statements (if-else, switch)
  * Modular programming using methods
  * Input validation and error handling
  * Logical problem-solving

## Task for the Day:
  * Build real-world scenario-based applications in C#
  * Implement secure admin and user functionalities
  * Practice dynamic data handling with arrays
  * Strengthen logic-building skill
  * Debug and refine existing code
  * Improve readability and structure of programs
  * Push LMS and Quiz Grader projects to GitHub
<<<<<<< HEAD

=======
>>>>>>> oops-csharp-practice
# Day — December 31, 2025 — Scenario-Based Programming in C#
## Topic: Utility Class – Math Operations

## What I Learned
    * Understanding the concept of Utility Classes in C#
    * Learning why utility classes mainly use static methods
    * Designing real-world math operation scenarios
    * Separating logic from execution using utility classes
    * Implementing common mathematical operations using static methods
    * Avoiding object creation for reusable logic
    * Designing a menu-driven Math Utility Application

## Implementing operations like:
    * Addition
    * Subtraction
    * Multiplication
    * Division (with divide-by-zero handling)
    * Modulus
    * Power calculation
    * Factorial calculation
    * Using switch-case for menu selection
    * Applying while loop for continuous execution
    * Validating user input to prevent runtime errors
    * Improving logical flow and decision-making
    * Writing clean, modular, and reusable code
    * Refining code readability and structure

## Key Concepts Applied:
    * Utility classes
    * Static methods
    * Menu-driven programming
    * Scenario-based application design
    * Switch-case statements
    * Loops (while)
    * Conditional statements (if-else)
    * Modular programming using methods
    * Input validation and error handling
    * Logical problem-solving

## Task for the Day:
    * Build a scenario-based Math Utility Application
    * Implement reusable static methods
    * Practice menu-driven program structure
    * Strengthen logic-building skills
    * Debug and refine the code
    * Improve code readability and modularity
    * Push Utility Math Operations project to GitHub

<!-- --------------------------------------------------------------- -->
## Day — January 1, 2026
## Topic: Scenario-Based Programming in C#
## Bank Account Manager & Cafeteria Menu App
## What I Learned

## Morning Session:
    * Designing a Bank Account Management System
    * Understanding real-world banking scenarios
    * Implementing customer account creation and management
    * Performing deposit and withdrawal operations
    * Checking account balance functionality
    * Using menu-driven programming with while loop
    * Applying switch-case for user interaction
    * Handling invalid input and insufficient balance cases
    * Writing modular methods for banking operations
    * Improving logical thinking through real-world simulations

## Afternoon Session:
    * Designing a Cafeteria Menu Application
    * Storing fixed menu items using string arrays
    * Displaying menu with index-based selection
    * Allowing users to place orders using menu indices
    * Calculating total bill amount

## Implementing reusable methods like:
    * DisplayMenu()
    * GetItemByIndex()
    * CalculateBill()
    * Using loops to handle multiple orders
    * Validating user input to avoid incorrect selections
    * Improving code structure and readability

## Key Concepts Applied:
    * Menu-driven programming
    * Scenario-based application design
    * Arrays (single-dimensional)
    * Loops (for, while)
    * Conditional statements (if-else, switch)
    * Modular programming using methods
    * Input validation and error handling
    * Logical problem-solving

## Task for the Day:
    * Build a Bank Account Management System
    * Implement secure and logical banking operations
    * Create a Cafeteria Menu App with bill calculation
    * Practice real-world scenario-based programming
    * Debug and refine both applications
    * Improve code readability and structure
    * Push both projects to GitHub

<!-- --------------------------------------------------- -->
## Day — January 2, 2026
## Topic: Scenario-Based Programming & OOP Concepts in C#
## Invoice Generator, Classes & Objects, Bus Route Distance Tracker
## What I Learned

## Morning Session:
 * Designing an Invoice Generator for Freelancers
 * Working with real-world invoice scenarios
 * Handling string inputs with multiple items and prices
 * Splitting strings to extract task names and amounts
 * Parsing numeric values from strings
 * Calculating total invoice amount dynamically
 * Using methods to separate business logic
 * Implementing menu-driven programs
 * Validating user input to avoid errors
 * Strengthening understanding of scenario-based programming

## Afternoon Session:
 * Understanding Object-Oriented Programming (OOP) concepts
 * Learning classes and objects through practical examples
 * Using constructors for object initialization
 * Applying the this keyword in constructor
 * Creating multiple objects from a single class
 * Designing a Bus Route Distance Tracker
 * Applying OOP concepts to a real-world transportation scenario
 * Tracking total distance using loops
 * Counting the number of stops dynamically
 * Using while loop for continuous execution
 * Asking user confirmation to continue or exit
 * Implementing conditional logic for user decisions

## Key Concepts Applied:
 * Scenario-based application design
 * Classes and objects
 * Constructors and this keyword
 * Methods and modular programming
 * String manipulation
 * Loops (while)
 * Conditional statements (if-else)
 * Menu-driven programming
 * Input validation and error handling
 * Logical and real-world problem-solving

## Tasks for the Day:
 * Build an Invoice Generator using scenario-based logic
 * Practice OOP concepts using classes and objects
 * Implement a Bus Route Distance Tracker
 * Apply loops and conditions to real-world problems
 * Improve code readability and structure
 * Debug and refine all programs
 * Push all work to GitHub

<!-- --------------------------------------------------------- -->
## Day — January 3, 2026
## Topic: Scenario-Based Programming, OOP Design & C# Language Fundamentals
## Festival Lucky Draw, Class Diagrams, C# Constructors & Keywords
## What I Learned

## Morning Session:
 * Designing a Festival Lucky Draw System using scenario-based logic
 * Understanding real-world use cases like prize distribution and random selection
 * Working with classes and objects to model participants and prizes
 * Implementing random number generation for lucky draw results
 * Using conditional statements to assign prizes based on outcomes
 * Applying loops to handle multiple participants
 * Understanding class diagrams (UML)
 * Identifying class components:
    * Class name
    * Attributes (fields)
    * Methods (functions)
* Learning relationships in class diagrams:
    * Association
    * Inheritance
    * Composition
* Mapping real-world problems into class diagram representations

## Afternoon Session:
 * Understanding constructors in C#
 * Learning the purpose of constructors for object initialization
 * Using parameterized constructors
 * Applying the this keyword to differentiate instance variables
 * Understanding constructor chaining
 * Learning commonly used C# keywords such as:
    * class, object, new
    * this, base
    * static, void
    * public, private, protected
 * Understanding access modifiers and their scope
 * Writing clean and readable C# code using proper keywords
 * Strengthening object-oriented thinking through constructor-based examples

## Key Concepts Applied:
 * Scenario-based programming
 * Classes and objects
 * Constructors and constructor chaining
 * this and base keywords
 * UML class diagrams
 * C# keywords and syntax fundamentals
 * Loops and conditional logic
 * Random number generation
 * Real-world problem modeling
 * Code structure and readability

## Tasks for the Day:
 * Implement a Festival Lucky Draw application
 * Create class diagrams for real-world scenarios
 * Practice different types of constructors in C#
 * Explore and apply essential C# keywords
 * Strengthen understanding of OOP design principles
 * Debug and refine all programs
 * Push all completed work to GitHub

<!-- ------------------------------------------------------ -->
## Day — January 4, 2026
## Topic: Inheritance in C# & Object-Oriented Design
## Concepts Covered: Single, Multilevel & Hierarchical Inheritance

## What I Learned
 * Understanding Inheritance in C#
 * Learned the concept of inheritance and its role in code reusability
 * Understood the IS-A relationship between base and derived classes
 * Used the : symbol to inherit one class from another
 * Learned when and why inheritance should be used in real-world applications
 * Types of Inheritance Implemented
    * Single Inheritance
        * One child class inheriting from one parent class
    * Multilevel Inheritance
        * A class derived from another derived class
    * Hierarchical Inheritance
        * Multiple subclasses inheriting from a single superclass
 * Key OOP Principles Applied
 * Method overriding to customize subclass behavior
 * Constructor chaining using base keyword
 * Proper use of access modifiers (public, protected)
 * Avoiding deep inheritance hierarchies
 * Following Liskov Substitution Principle (LSP)

## Key Concepts Applied
 * Inheritance (:)
 * IS-A relationship
 * Code reusability
 * Method overriding
 * Constructor chaining
 * Polymorphism (basic usage)
 * Clean class design
 * Real-world problem modeling

## Tasks Completed
 * Implemented multiple inheritance-based programs in C#
 * Practiced single, multilevel, and hierarchical inheritance
 * Designed real-world scenarios using inheritance
 * Tested and debugged all programs
 * Improved understanding of object-oriented design
 * Pushed all completed work to GitHub

 <!-- --------------------------------------------------------------- -->
## Day — January 5, 2026
## Topic: Scenario-Based Programming in C# & Object-Oriented Design
## Project: Hospital & Patient Management System

## What I Learned
 * Understanding scenario-based application development in C#
 * Learned how to model real-world hospital workflows using OOP
 * Understood relationships between Hospital, Doctor, and Patient classes
 * Applied object-oriented thinking instead of procedural coding
 * Learned the importance of proper class responsibility design
 * Improved ability to translate real-life problems into code structure

## Scenario Description
 * Designed a Hospital & Patient Management System
 * Hospital manages patients and doctors
 * Patients are registered with basic detail
 * Doctors are assigned to patients for consultation
 * System follows realistic execution flow instead of hardcoded output

## Key OOP Principles Applied
 * Encapsulation to protect patient and medical details
 * Inheritance for role-based entities (Doctor, Specialist)
 * Polymorphism for role-specific behavior implementation
 * Constructor usage for proper object initialization
 * Method overriding where behavior differed
 * Proper use of access modifiers (private, protected, public)

## Key Concepts Applied
 * Classes & Objects
 * HAS-A relationship (Hospital has Doctors and Patients)
 * IS-A relationship (Specialist is a Doctor)
 * Scenario-based logic flow
 * Code reusability
 * Clean class design
 * Real-world problem modeling

## Tasks Completed
 * Designed Hospital, Patient, and Doctor classes
 * Implemented patient registration functionality
 * Implemented doctor management logic
 * Assigned patients to doctors
 * Tested system with multiple patients
 * Debugged logical and design issues
 * Improved code readability and structure
 * Pushed completed Hospital Management System to GitHub

<!-- ---------------------------------------------------------------- -->
## Day — January 6, 2026
## Topic: Scenario-Based Programming & OOP in C#
## Projects: Vehicle Rental System, Bird Sanctuary, Call Log Manager

## What I Learned
 * Designed multiple scenario-based systems in one day
 * Strengthened Inheritance, Interfaces, and Polymorphism skills
 * Modeled real-world entities using classes and objects
 * Applied encapsulation and clean OOP design
 * Used arrays and iteration for dynamic behavior

## Morning Session: Vehicle Rental System
 * Managed Vehicles: Bike, Car, Truck, and Customers
 * Implemented IRentable interface with CalculateRent()
 * Used protected fields in Vehicle class
 * Applied polymorphism for rental calculation
 * Tested customer rentals

## Afternoon Session:
    # Bird Sanctuary System
        * Created Bird base class and derived classes
        * Implemented IFlyable and ISwimmable interfaces
        * Stored birds in array and iterated through them
        * Used polymorphism to call Fly/Swim dynamically
        * Simulated bird behaviors

    # Customer Service Call Log Manager
        * Stored call logs with phone, message, and timestamp
        * Implemented AddCallLog(), SearchByKeyword(), FilterByTime()
        * Used array to store and iterate logs
        * Filtered logs by keywords and time range
        * Tested addition, search, and filtering

## Key OOP Principles Applied
 * Classes & Objects
 * Inheritance and IS-A relationships
 * Interfaces for behavior contracts
 * Polymorphism for dynamic behavior
 * Encapsulation and constructor usage
 * Separation of responsibilities

## Tasks Completed
 * Designed and implemented three systems
 * Tested all features for correctness
 * Used arrays and iteration
 * Applied method overriding and interface implementation
 * Maintained clean code structure
 * Pushed projects to GitHub

 <!-- --------------------------------------------------- -->
## Day — January 7, 2026
## Topic: Core OOP Concepts in C#
## Projects: OOP Concept Demos, Employee Wage Computation System

## What I Learned
 * Understood and applied all four core OOP principles
 * Learned how encapsulation, abstraction, inheritance, and polymorphism work together
 * Modeled real-world problems using proper OOP design
 * Improved code structure and reusability
 * Strengthened object-oriented thinking in C#

## Morning Session: "Core OOP Concepts in C#"
 * Applied Encapsulation using private fields and public properties
 * Implemented Abstraction using abstract classes and interfaces
 * Used Inheritance to create IS-A relationships between classes
 * Applied Polymorphism through method overriding and base-class references
 * Compared real-world scenarios to OOP concepts for better understanding

## Afternoon Session: "Employee Wage Computation Problem" 
 * Modeled Employee class with encapsulated wage data  
 * Stored employee details like ID, name, and working hours  
 * Calculated daily and monthly wages using methods  
 * Applied validation for working hours and wage limits  
 * Used arrays to store and process multiple employees  
 * Applied polymorphism for different employee types  

## Key OOP Principles Applied
 * Encapsulation and data hiding
 * Abstraction using abstract classes and interfaces
 * Inheritance for code reuse
 * Polymorphism for dynamic behavior
 * Constructors and property validation

## Tasks Completed
 * Implemented examples covering all OOP principles
 * Designed Employee Wage Computation system
 * Tested abstraction and polymorphic behavior
 * Validated business rules
 * Maintained clean and structured code
 * Pushed implementations to GitHub

 <!-- ----------------------------------------------------------- -->
<<<<<<< HEAD
 
=======
>>>>>>> origin/core-csharp-practice
=======
 ## Day — February 7, 2026
## Topic: Patient Management Module

## Scenarios Implemented
* Implemented patient registration workflow
* Enabled uniqueness validation using phone/email
* Added functionality to update patient information
* Implemented patient search by ID, phone, and name
* Enabled viewing of patient visit history

## Key Concepts Applied
* SQL INSERT and UPDATE operations
* Search using LIKE and exact match queries
* Primary key and auto-increment handling
* JOIN queries for visit history retrieval
* ResultSet navigation for displaying data

## Tasks Completed
* Developed UC-1.1 Register New Patient
* Developed UC-1.2 Update Patient Information
* Implemented UC-1.3 Search Patient Records
* Implemented UC-1.4 View Patient Visit History
* Strengthened understanding of patient data management and relational queries

<!-- ------------------------------------------------------ -->
## Day — February 8, 2026
## Topic: Doctor Management Module

## Scenarios Implemented
* Added doctor profile creation functionality
* Enabled specialty assignment and updates
* Implemented viewing doctors by specialty
* Enabled soft deletion/deactivation of doctor profiles

## Key Concepts Applied
* Foreign key relationships
* Transaction handling for data integrity
* JOIN queries for specialty mapping
* Nested SELECT queries for validation
* Soft delete using UPDATE statements

## Tasks Completed
* Implemented UC-2.1 Add Doctor Profile
* Implemented UC-2.2 Assign/Update Doctor Specialty
* Developed UC-2.3 View Doctors by Specialty
* Implemented UC-2.4 Deactivate Doctor Profile
* Strengthened understanding of doctor data and referential integrity
<!-- ---------------------------------------------------------- -->
## Day — February 9, 2026
## Topic: Appointment Scheduling System

## Scenarios Implemented
* Implemented appointment booking functionality
* Enabled doctor availability checking
* Added appointment cancellation workflow
* Implemented appointment rescheduling logic
* Created daily appointment schedule view

## Key Concepts Applied
* PreparedStatement usage for secure queries
* Transactions for appointment operations
* GROUP BY and COUNT for slot availability
* Multi-table JOIN queries
* ORDER BY for schedule sorting

## Tasks Completed
* Implemented UC-3.1 Book New Appointment
* Developed UC-3.2 Check Doctor Availability
* Implemented UC-3.3 Cancel Appointment
* Implemented UC-3.4 Reschedule Appointment
* Developed UC-3.5 View Daily Appointment Schedule
* Strengthened understanding of scheduling logic and transaction handling

<!-- ------------------------------------------------------------- -->
## Day — February 10, 2026
## Topic: Visit Management & Medical Records

## Scenarios Implemented
* Implemented patient visit recording after appointments
* Enabled viewing of patient medical history
* Added prescription recording functionality

## Key Concepts Applied
* Transaction management for visit and appointment updates
* One-to-many relationships (visits and prescriptions)
* JOIN queries across multiple medical tables
* Batch INSERT operations
* Chronological data ordering

## Tasks Completed
* Implemented UC-4.1 Record Patient Visit
* Developed UC-4.2 View Patient Medical History
* Implemented UC-4.3 Add Prescription Details
* Strengthened understanding of medical record management and data consistency

<!-- ---------------------------------------------------------- -->
## Day — February 11, 2026
## Topic: Billing & Payment Module

## Scenarios Implemented
* Implemented bill generation for patient visits
* Added payment recording functionality
* Enabled viewing outstanding bills
* Generated revenue reports

## Key Concepts Applied
* Aggregate functions (SUM, COUNT)
* Foreign key mapping with visits and patients
* Transaction handling for payments
* Reporting queries using GROUP BY and HAVING
* Date range filtering using BETWEEN

## Tasks Completed
* Implemented UC-5.1 Generate Bill for Visit
* Developed UC-5.2 Record Payment
* Implemented UC-5.3 View Outstanding Bills
* Developed UC-5.4 Generate Revenue Report
* Strengthened understanding of financial data handling and reporting

<!-- ------------------------------------------------------------- -->
## Day — February 12, 2026
## Topic: System Administration & Database Operations

## Scenarios Implemented
* Managed specialty lookup reference data
* Implemented database backup workflow
* Enabled viewing system audit logs

## Key Concepts Applied
* CRUD operations on reference tables
* Foreign key constraint validation
* DatabaseMetaData usage
* Trigger-based audit logging
* Complex WHERE conditions and subqueries

## Tasks Completed
* Implemented UC-6.1 Manage Specialty Lookup
* Developed UC-6.2 Database Backup Trigger process
* Implemented UC-6.3 View System Audit Logs
* Strengthened understanding of database administration and monitoring
<!-- ----------------------------------------------------------------- -->
## Day — February 13, 2026
## Topic: Email Validator – College Admission Portal

## Scenarios Implemented
* Developed backend module for email validation in student registration system
* Accepted user email inputs during admission process
* Implemented regex-based validation to verify correct email format
* Handled invalid inputs and exceptions during validation
* Ensured duplicate and malformed email entries are prevented

## Key Concepts Applied
* Regular Expressions (Regex) for pattern validation
* Pattern and Matcher usage
* Exception handling for invalid input cases
* Multithreading concepts for responsive validation flow
* IO file handling for storing and verifying email data
* Annotation-based validation with regex rules
* Modular method design for reusable validation logic

## Tasks Completed
* Designed email validation module using C#
* Implemented regex pattern for standard email format
* Validated usernames with alphanumeric characters, dots, and underscores
* Verified domain and extension formats (.com, .in, .org, .edu, etc.)
* Tested module with valid and invalid email scenarios
* Handled errors using structured exception handling
* Strengthened understanding of regex validation and backend input processing

<!-- ------------------------------------------------------------------ -->
## Day — February 14, 2026
## Topic: NotifyHub – Concurrent Notification Processing System

## Scenarios Implemented
* Designed a notification processing system to handle email, SMS, and app alerts
* Implemented concurrent intake of notifications into in-memory collections
* Enabled asynchronous and multithreaded notification sending
* Prioritized notifications based on priority levels
* Ensured failures in one notification do not affect others
* Applied validation rules using annotations/attributes within notification model

## Key Concepts Applied
* Object-Oriented Programming (encapsulation, inheritance, polymorphism, abstraction)
* Collections framework for managing notification queues
* Multithreading for parallel notification processing
* Asynchronous programming using async/await and tasks
* Annotation/attribute-based validation for notification data rules
* Concurrency and synchronization for safe status updates
* Exception handling for runtime and delivery failures
* Dynamic selection of sending logic based on notification type

## Tasks Completed
* Designed notification entity with ID, recipient, message, priority, and timestamp
* Implemented validation rules for notification data using attributes
* Created in-memory notification holding and prioritization mechanism
* Developed concurrent processing logic for sending notifications
* Implemented dynamic delivery strategies for multiple notification types
* Added failure handling and status tracking for each notification
* Ensured system scalability and responsiveness under high notification load
* Strengthened understanding of concurrent system design and asynchronous processing

<!-- --------------------------------------------------------------------- -->
## Day — February 16, 2026
## Topic: Bank Transaction Processing System

## Scenarios Implemented
* Designed bank transaction processor to handle high-volume operations
* Created SQL tables for Accounts and Transactions
* Implemented transaction insertion and account balance updates
* Simulated parallel withdrawals on the same account
* Prevented race conditions during concurrent processing
* Implemented rollback mechanisms for failure scenarios

## Key Concepts Applied
* Database transaction management for atomicity
* Concurrency handling in financial operations
* Multithreading for parallel withdrawal simulation
* In-memory caching using Dictionary<int, Account>
* Exception handling for insufficient balance scenarios
* Data consistency and rollback strategies
* Unit testing for concurrent and failure cases

## Tasks Completed
* Created Accounts and Transactions database tables
* Implemented transaction insert operations
* Updated account balance securely during withdrawals
* Simulated 50 concurrent withdrawals on a single account
* Implemented synchronization to prevent race conditions
* Maintained in-memory account cache using dictionary structure
* Tested insufficient balance handling
* Tested concurrent withdrawal processing
* Implemented rollback logic on transaction failure
* Strengthened understanding of transaction processing and concurrency control

<!-- ------------------------------------------------------------- -->
## Day — February 17, 2026
## Project: TechVille Smart City Management System
## Topic: Modules 1, 2 & 3 Implementation

## Scenarios Implemented
* Developed Citizen Registration Portal for capturing citizen details
* Implemented service eligibility calculation based on age, income, and residency
* Built Service Eligibility Checker using decision-making and iteration logic
* Enabled multi-member registration using loops
* Organized citizen data using arrays for efficient storage and retrieval
* Structured zone-wise and sector-wise citizen data representation

## Key Concepts Applied
* Variables, literals, primitive data types, and basic I/O operations
* Arithmetic, comparison, and logical operators
* Conditional statements (if-else, switch, ternary)
* Iteration constructs (for, while, do-while, for-each)
* Arrays (single and multi-dimensional)
* Array operations: searching, sorting, copying
* Memory management concepts and role of JVM & garbage collection

## Tasks Completed
* Implemented Module 1: Citizen Registration Portal
* Implemented Module 2: Service Eligibility Checker
* Implemented Module 3: Smart Citizen Database
* Created eligibility calculation logic
* Built loops for registering multiple citizens
* Stored and managed citizen data using arrays
* Strengthened understanding of programming basics, logic building, and memory handling

<!-- ---------------------------------------------------------- -->
## Day — February 18, 2026
## Project: TechVille Smart City Management System
## Topic: Modules 4, 5 & 6 Implementation

## Scenarios Implemented
* Built Citizen Profile Management system with reusable string utilities
* Implemented validation, search, and update functionalities for citizen profiles
* Developed robust error-handling mechanisms for registration system
* Designed object-oriented structure for city services framework
* Created service-specific modules for healthcare, education, and transportation

## Key Concepts Applied
* String manipulation and reusable methods
* Functions and modular programming
* Pass by value and pass by reference concepts
* Exception handling with try-catch-finally
* Custom exception creation and logging mechanisms
* OOP fundamentals: classes, objects, constructors, access modifiers
* Encapsulation and instance vs class variables

## Tasks Completed
* Implemented Module 4: Citizen Profile Management
* Implemented Module 5: Robust Registration System
* Implemented Module 6: City Services Framework
* Created string utility and validation methods
* Added exception handling and logging mechanisms
* Designed Citizen and Service classes with proper encapsulation
* Implemented specialized service classes
* Strengthened understanding of OOP design, modular programming, and error handling

<!-- ------------------------------------------------------------ -->
## Day — February 19, 2026
## Topic: SonarQube Integration in Address Book

## Scenarios Implemented
* Integrated SonarQube for static code analysis in Address Book project
* Configured project settings and scanning workflow
* Performed initial code quality analysis
* Reviewed detected bugs, vulnerabilities, and code smells
* Prepared project for continuous quality monitoring

## Key Concepts Applied
* Static code analysis for improving software quality
* Code smell detection and bug identification
* Quality gates and code standards enforcement
* Maintainability and technical debt monitoring
* Integration of analysis tools into development workflow

## Tasks Completed
* Installed and configured SonarQube
* Connected Address Book project with SonarQube scanner
* Executed first project scan
* Analyzed reports generated by SonarQube
* Identified improvement areas in codebase
* Strengthened understanding of automated code quality practices

<!-- ---------------------------------------------------------- -->
## Day — February 19, 2026
## Topic: MSTest Integration in Address Book

## Scenarios Implemented
* Added MSTest framework to Address Book project
* Created unit testing project structure
* Developed test cases for core functionalities
* Executed tests for validation and logic verification
* Established base for automated testing workflow

## Key Concepts Applied
* Unit testing principles
* Test case design and validation
* Automated test execution
* Software reliability through testing
* Foundation for test-driven development

## Tasks Completed
* Installed and configured MSTest framework
* Created and linked test project to main Address Book solution
* Wrote unit tests for contact creation, update, and deletion
* Executed and verified test results
* Improved confidence in application functionality
* Strengthened understanding of software testing practices

<!-- ----------------------------------------------------- -->
## Day — February 17, 2026
## Topic: UC-17 & UC-18 Implementation in Address Book

## Scenarios Implemented
* Implemented non-blocking I/O operations during CRUD activities
* Enabled asynchronous handling for CSV File, JSON File, and JSON Server data sources
* Ensured main thread remains responsive while performing file and server operations
* Added database storage capability for Address Book
* Extended system to support new data sources without modifying existing logic

## Key Concepts Applied
* Asynchronous programming for non-blocking I/O operations
* CRUD operations across multiple data sources
* Open–Closed Principle (OCP) for scalable system design
* Data persistence using database integration
* Modular architecture for adding new data sources

## Tasks Completed
* Implemented UC-17 for asynchronous CRUD operations on CSV, JSON, and JSON Server
* Ensured main application thread is not blocked during I/O processes
* Implemented UC-18 for saving Address Book data into Database
* Designed system to allow addition of new data sources without modifying existing code
* Verified OCP compliance while integrating database and server sources
* Tested functionality across all data sources
* Strengthened understanding of scalable architecture and asynchronous processing

>>>>>>> oops-csharp-practice
=======
## Day — February 6, 2026
## Topic: SQL Queries, Normalization & ER Diagram

## Scenarios Implemented
    * Practiced SQL database creation and table design using DDL commands
    * Performed data manipulation using INSERT, UPDATE, DELETE, and SELECT queries
    * Applied DCL commands for user permissions and access control
    * Executed TCL commands to manage transactions and ensure data integrity
    * Implemented normalization techniques to structure data efficiently
    * Designed an ER diagram representing entities, attributes, and relationships

## Key Concepts Applied
    * DDL (CREATE, ALTER, DROP) for database schema definition
    * DML (INSERT, UPDATE, DELETE, SELECT) for data operations
    * DCL (GRANT, REVOKE) for security and access management
    * TCL (COMMIT, ROLLBACK, SAVEPOINT) for transaction control
    * Database normalization (1NF, 2NF, 3NF) to remove redundancy
    * ER modeling concepts: entities, relationships, primary and foreign keys

## Tasks Completed
    * Created and modified database tables using DDL queries
    * Performed CRUD operations using DML commands
    * Managed permissions using DCL statements
    * Controlled transactions using TCL commands
    * Normalized database structure up to required normal form
    * Designed ER diagram for structured representation of database system
    * Strengthened understanding of relational database design and SQL operations

>>>>>>> dbms-practice
