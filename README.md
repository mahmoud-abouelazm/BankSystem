# Bank Account Management System

## Overview
This **Bank Account Management System** is a simple console application written in **C#**. It allows users to manage different types of bank accounts, including Savings, Checking, Investment, and Credit accounts. Each account type has specific behaviors such as deposits, withdrawals, and interest calculation (for interest-earning accounts).

## Features

- **Create and manage accounts** (Savings, Checking, Investment, Credit).
- **Deposit and Withdraw** money from accounts.
- **Interest Calculation** for Savings and Investment accounts.
- **Handle Exceptions** for invalid operations such as negative withdrawals or exceeding credit limits.
- **Simple Console Interface** for interaction.

---

## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
3. [Account Types](#account-types)
4. [Interest Calculation](#interest-calculation)
5. [Example Output](#example-output)
---

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-repo/bank-system.git
   ```

2. **Navigate to the project directory**:
   ```bash
   cd bank-system
   ```

3. **Open the solution in Visual Studio or any C# IDE**:
   - Open the `.sln` file.

4. **Build the project**:
   - Compile and run the project from your IDE.

---

## Usage

Once the application is running, you can interact with the console to create and manage different types of bank accounts.

1. **Creating an account**: The system will prompt you to enter the account type, account holder's name, and initial balance.
   
2. **Deposit/Withdraw**: You can deposit or withdraw money from any account.

3. **Interest Calculation**: For interest-earning accounts, such as **Savings** or **Investment**, interest will be calculated and applied based on the balance.

---

## Account Types

### 1. **Savings Account**
- Inherits from `BankAccount`.
- Implements the `IInterestEarning` interface.
- **3% monthly interest** is applied.

### 2. **Checking Account**
- Basic bank account with standard operations.
- No interest is applied.

### 3. **Investment Account**
- Inherits from `BankAccount`.
- Implements `IInterestEarning`.
- **5% monthly interest** is applied.

### 4. **Credit Account**
- Includes a `CreditLimit` property.
- Allows withdrawals beyond the balance but within the credit limit.
  
---

## Interest Calculation

Interest is automatically applied to Savings and Investment accounts using the `IInterestEarning` interface.

- **SavingsAccount**: Applies **3% monthly interest**.
- **InvestmentAccount**: Applies **5% monthly interest**.

```csharp
public interface IInterestEarning
{
    decimal CalculateInterest();
    void ApplyInterest();
}
```

**Example:**

For a **SavingsAccount** with a balance of `$1000`, the interest applied will be `$30` (3% of $1000).

---

## Example Output

```plaintext
Creating a SavingsAccount for John Doe with initial balance: $1000.00
Deposit $500 into SavingsAccount. New Balance: $1500.00
Withdraw $200 from SavingsAccount. New Balance: $1300.00
Applying 3% interest. Interest applied: $39.00. New Balance: $1339.00
```
---

## Contact

For questions or suggestions, contact:

- **Email**: mahmoud.reda.abouelazm@gmail.com

---
