# Linq Course Learning Notes

## Introduction to Linq
-  Lambda expression are used to create anonymous functions. Function with no name
    
    ```
        Lambda expression
            bool isAnyLargerThan100 = IsAny(numbers, num => num > 100);
        
        traditional way

            private static bool IsLargerThan100(int num)
            {
                return num > 100;
            }

    ```
    - => : lambda declaration operator 
    - num is parameter
    - if parameter is more than 1, declare them like this. (x,y)
    - you don't need to declare type. THe method declared with the lambda expression is used in place of this parameter
    - there is no use of return key word. The part on the right side of the arrow is returned
    - lambda expression cannot be assigned to implicitly typed variable e.g. var cannot be used.
    - We can use function like any other types - store them in variables or pass as parameters
    ```
    LINQ Implementation
        public static bool Any<TSource>(
            this IEnumerable<TSource> source, Func<TSource, bool> predicate
        )
        {
            if(source == null){
                throw Error.ArgumentNull("source");
            }
            if(predicate == null){
                throw Error.ArgumentNull("predicate");
            }
            foreach(TSource element in source){
                if(predicate(element)) return true;
            }
            return false;
        }

    Course Implementation
        private static bool IsAny<T>(
            IEnumerable<T> numbers, Func<T, bool> predicate
        ){
            foreach(var num in numbers){
                if(predicate(num)){
                    return true;
                }
            }
            return false;
        }
    ```
- **Linq extension methods** 
    - An extension method is a method defined outside of a type, that can be called upon this type's objects as a regular member method
    - extension methods allows us to add new functionality to a type without modifying it
    - all extension methods must be static
    - Both LiInst and an array implement the IEnumerable<T> interface
- IEnumerable<T> and method chaining 
    - This is implemented by Array, List, HashSet, Dictionary
    - This interface enable iterating collections with foreach loop
    - If a type does not implement the IEnumerable Interface, it is not possible to iterate with foreach loop
    - Most of the Linq methods are extension methods of IEnumerable<T>. This mean, we can use it with any method that implements IEnumerable<T>
        - e.g. array.First();
        - list.First();
        - queue.First();
    - It does not expose any methods from the collection. LINQ methods never modify the input collection
        - collection.Append(element);
        - The existing collection object will not be notified.
        - A new collection will be created.
        - Where (filter collection)and OrderBy , produces the result as IEnumerable<T> and do not modify the input collection

    ```
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)


        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(
            this IEnumerable<TSource> source, Func<TSource, TKey> keySelector
        )
    ```
    - LINQ methods take IEnumerable<T> as a parameter
    - LINQ methods return IEnumerable<T> as a result 
        - input and output of same type
    ```
        var result = list.LinqMethod();
        var result = result.AnotherLinqMethod();

    ```
- **Deferred execution** : Deferred execution means that the evaluation of a LINQ expression is delayed until the value is actually needed.
    - It allows you to work on the latest data.
    - Deferred execution improves the performance as the query is materialised only when it is actually needed, so we can avoid unnecessary execution.
- **Method syntax vs Query syntax**
    - Method Syntax
        - Pure C#
    - Query Syntax
        - similar to SQL
        - not all LINQ operations are supported, you might need to combine with method syntax
        - no distinct method
        - some operations are simpler to write
