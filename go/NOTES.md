# Notes

Statically typed. Garbage collection. Single binary. Cross-platform. Amazing standard library with built-in testing, concurrency, http server, etc. Very fast compilation and execution speed. Standard code formatting and documentation. Simple and consistent.

## Variables

```go
var explicit int // Explicitly typed
implicit := 10 // Implicitly typed
const Age = 21 // Implicitly typed Constant
```

Constants can only be numbers, characters, strings or booleans.

## packages

All source files in a directory must share the same package name.

## Scope

Variables with PascalCase are accessible by other packages.

Variables with camelCase are only accessible by its package.

## Functions

no type inference

can return multiple values

## Type conversion

```go
var i int = 10
var f float64 = float64(i)
```

## channels

An unbuffered channel blocks on send until a receiver is ready to read
