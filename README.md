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