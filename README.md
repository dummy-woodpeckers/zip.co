# Zip Candidate User API Challenge: C#
We have a fictitious scenario where we'd like to build an API to manage Zip Pay users. We require the ability to create, get, and list users. Once we create users, we need the ability for the user to create an account.

This should be implemented with an API and database.

## Business Requirements

* Should not allow more than one user with the same email address
* Zip Pay allows credit for up to $1000, so if `monthly salary - monthly expenses` is less than $1000 we should not create an account for the user and return an error

## Tech Requirements

* API: Your choice!
* DB: Your choice!

We'd recommend using docker/docker-compose to stand this up, but if you'd like to use something else, that's okay too.

## API Requirements

1. The following Endpoints are required:
    * Create user
      * Fields to be provided and persist
        * Name
        * Email Address (Must be unique)
        * Monthly Salary (Must be a positive number - for simplicity, pretend there is no such thing as income tax)
        * Monthly Expenses (Must be a positive number)
    * List users
    * Get user
    * Create an account
      * Given a user, create an account
      * Should take into account the business requirements above
      * Up to you to decide the appropriate fields to persist here
    * List Accounts
1. Should be robust and include relevant response codes for different scenarios
1. No need to implement any kind of auth for this test

## Database Requirements

Users and accounts should persist to a database of your choice

## Definition of Done

This solution should be what you consider to be production ready, so think carefully about what you want to include. Please submit as a git repo and send us a link when done.

We value your time, so we don't want you to spend a massive amount of time on this so we'd recommend spending around 3-4 hours on this.