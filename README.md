# Builder Test Sample
Show how to use a builder with unit tests.

## Give a Star! :star:

If you complete this kata, please give it a star to signify your accomplishment! Thanks!

You can use this sample as a starting point to practice using the Builder Pattern for your unit test data.

[Source - Using the Builder Pattern for Your Test Data](https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data)

It includes a small working test data builder for the `Order` class, but requires you to create additional builders for `Customer` and `Address`. You can go through the comments in `OrderService` to build out the `PlaceOrder` method's functionality as a [kata](https://github.com/ardalis/kata-catalog) to practice applying this pattern.

## Kata Instructions

Fork or clone the repository locally so you can work on it. You should be able to run the tests using xunit either from the command line or using Visual Studio. Run the tests. The included test(s) should pass.

Open `OrderService.cs`. Read through the TODO comments. Each one represents a new piece of functionality to be added and tested. Write a test in `OrderServicePlaceOrder` for each new TODO item. Be sure to use a Builder to create the order and its associated customer and address. Verify the test fails when you first run it, since you haven't yet implemented the code that will make it pass. Then add the code. Once you see the test pass (and all other tests still pass), you should remove the TODO comment (and optionally commit your code to your local repository).

Continue until no more TODO comments remain and all tests are passing. If you're using Visual Studio, you can use the Task List window to see a list of your remaining TODO items:

![image](https://user-images.githubusercontent.com/782127/44723822-1134e000-aa9f-11e8-957a-78bb8abf118c.png)

### Tips

There are generally two approaches to the Builder pattern. The simpler one is shown in the OrderBuilder that is provided. In this approach, a new instance of the thing-to-be-built is created as a private field when the Builder is created. It is manipulated by the Builder methods and then simply returned by `Build`. Something to watch out for with this approach is reuse of the Builder, since any calls to Builder methods after `Build` has been called will still modify the instance that was previously returned. You can correct this by re-instantiating the private field when `Build` is called.

The second approach requires a bit more code but is useful when you can't just instantiate the object initially. You can try out this approach when you build a `CustomerBuilder` as part of this exercise. `Customer` has a parameterized constructor that requires an `id`, and its `Id` property is private. Thus, you can't just instantiate a private `Customer` instance when you create the `CustomerBuilder`. Instead, you should store each property value in its own private field, and then create the `Customer` instance in the `Build` method. This is the "more correct" way to implement the pattern, but it does require more code than the "shortcut" approach of just creating the instance when you create the builder.

