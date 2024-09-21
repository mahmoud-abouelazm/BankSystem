# Bank Account Management System

## Overview

This **Bank Account Management System** is a console application written in C#. It manages various types of bank accounts including **Savings Account**, **Checking Account**, **Credit Account**, and **Investment Account**. The system allows users to perform basic banking operations such as deposits, withdrawals, and interest calculations.

## Features

1. **Account Types**:
   - **Savings Account**: Earns 3% monthly interest.
   - **Checking Account**: Basic account for everyday transactions, no interest.
   - **Credit Account**: Supports credit limits and withdrawals beyond available balance.
   - **Investment Account**: Earns 5% monthly interest.

2. **Operations**:
   - **Deposit**: Add money to an account.
   - **Withdraw**: Withdraw money from an account if the balance (or credit limit) allows.
   - **Interest Calculation**: Applies interest to applicable accounts.
   - **Check Balance**: View current account balance.

3. **Error Handling**: 
   - Handles insufficient funds for withdrawals.
   - Ensures non-negative deposit/withdrawal amounts.

## Project Structure

The project follows an object-oriented design using inheritance and interfaces. Below is the class structure:

- **BankAccount (Base Class)**:
  - Represents a general bank account.
  - Contains properties for `AccountHolderName` and `Balance`.
  - Provides methods for `Deposit`, `Withdraw`, and `CheckBalance`.

- **SavingsAccount (Derived Class)**:
  - Inherits from `BankAccount`.
  - Implements `IInterestEarning` to calculate and apply a 3% monthly interest.

- **CheckingAccount (Derived Class)**:
  - Inherits from `BankAccount`.
  - No interest applied, but includes all standard bank operations.

- **CreditAccount (Derived Class)**:
  - Inherits from `BankAccount`.
  - Supports withdrawals beyond available balance up to a defined `CreditLimit`.

- **InvestmentAccount (Derived Class)**:
  - Inherits from `BankAccount`.
  - Implements `IInterestEarning` to calculate and apply a 5% monthly interest.

- **IInterestEarning (Interface)**:
  - Defines two methods: `CalculateInterest()` and `ApplyInterest()`.
  - Implemented by interest-earning accounts (Savings and Investment).

## How to Run the Application

### Prerequisites

- .NET SDK installed (preferably version 6.0 or higher).
- A C# IDE or editor (such as Visual Studio, Rider, or Visual Studio Code with C# extension).
