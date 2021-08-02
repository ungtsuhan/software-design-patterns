# Builder Design Pattern

## Intent

Seperate the construction of a complex object from its representation so that the same construction process can create different representations.

## Applicability

Use the Builder pattern when 

- the algorithm for creating a complex object should be independent of the parts that make up the object and how they are assembled.

- the construction process must allow different representations for the object that's constructed.

## Structure

## Particippants

- Builder ()

	- specifies an abstract interface for creating parts of a Product object.

- Concrete Builder ()

	- constrcuts and assembles parts of the product by implementing the Builder interface.

	- defines and keeps track of the representation it creates.

	- provides an interface for retrieving the product (e.g., ).

- Director

	- constructs an object using the Builder interface.

- Product

	- represents the complex object under constructing. Concrete Builder builds the product's internal representation and defines the process by which it's assembled.

	- includes classes that define the constituent parts, including interface for assembling the parts into the final result.

## Collaborations

- The client creates the Director object and configures it with the desired Builder object.

- Director notifies the builder whenever a part of the product should be built.

- Builder handles requests from the director and adds parts to the product.

- The client retrieves the product from the builder.

## Consequences

- pros:

	- Able to vary a product's internal representation.

	- Isolates code for construction and representations.

	- Each ConcreteBuilder contains all the code to create and assemble a particular kind of product. Different director can reuse same code to build Product variants from same set of parts.
	
	- Gives you finer control over the construction process. Builder pattern construct the product step by step under the director's control.