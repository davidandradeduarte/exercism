# Notes

Systems programming language. Runs blazingly fast. Prevents segfaults. Garanteed thread safety. No garbage collection (it has ownership instead).

## Package manager

Cargo is the package manager and provides commands to build, test and distribute Rust crates (packages).

[crates.io](https://crates.io/) is the public package registry.

## Functions

`fn` keyword to define functions.

main is the entry point.

the `return` keyword is not needed when the returned value is the last expression in the function. In this case the ; is omitted:

```rust
fn foo() -> i32 {
    3
}
```

## Enums

The possible values of an enum are called `variants`.

## Pattern matching

`match` keyword to match on values.
