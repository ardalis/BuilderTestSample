# Builder Test Sample
Show how to use a builder with unit tests.

You can use this sample as a starting point to practice using the Builder Pattern for your unit test data. [Source - Using the Builder Pattern for Your Test Data](https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data) It includes a small working test data builder for the `Order` class, but requires you to create additional builders for `Customer` and `Address`. You can go through the comments in `OrderService` to build out the `PlaceOrder` method's functionality as a [kata](https://github.com/ardalis/kata-catalog) to practice applying this pattern.

## Kata Instructions

Fork or clone the repository locally so you can work on it. You should be able to run the tests using xunit either from the command line or using Visual Studio. Run the tests. The included test(s) should pass.

Open `OrderService.cs`. Read through the TODO comments. Each one represents a new piece of functionality to be added and tested. Write a test in `OrderServicePlaceOrder` for each new TODO item. Be sure to use a Builder to create the order and its associated customer and address. Verify the test fails when you first run it, since you haven't yet implemented the code that will make it pass. Then add the code. Once you see the test pass (and all other tests still pass), you should remove the TODO comment (and optionally commit your code to your local repository).

Continue until no more TODO comments remain and all tests are passing.
