# 📘 C# Integral Types: A Study Guide

Integral types in C# are used to represent whole numbers. They are **value types** and are fundamental for a wide range of programming tasks. This guide covers the various integral types available in C#, their characteristics, and how to use them.

---

## 🧮 Signed vs. Unsigned Integers

A key distinction among integral types is whether they are **signed** or **unsigned**:

- **Signed Integers**:

  - Can represent **both positive and negative** whole numbers.
  - Use one bit (the most significant bit) to indicate the sign (positive or negative).

- **Unsigned Integers**:

  - Represent only **non-negative** values (zero and positive).
  - Can store larger positive values than their signed counterparts of the same size.

---

## 📊 Integral Type Reference

C# provides a variety of integral types to accommodate different ranges of values and memory requirements.

---

### 🔹 8-Bit Integers

#### `sbyte`

- **.NET Type**: `System.SByte`
- **Size**: 8-bit signed integer
- **Range**: `-128` to `127`
- **Description**: Represents small signed integers.
- **Example**:

  ```csharp
  sbyte smallSignedNumber = -100;
  ```

#### `byte`

- **.NET Type**: `System.Byte`
- **Size**: 8-bit unsigned integer
- **Range**: `0` to `255`
- **Description**: Used for raw binary data or small non-negative numbers.
- **Example**:

  ```csharp
  byte smallUnsignedNumber = 200;
  ```

---

### 🔹 16-Bit Integers

#### `short`

- **.NET Type**: `System.Int16`
- **Size**: 16-bit signed integer
- **Range**: `-32,768` to `32,767`
- **Description**: Suitable for moderate-range integers with some memory savings.
- **Example**:

  ```csharp
  short mediumSignedNumber = -15000;
  ```

#### `ushort`

- **.NET Type**: `System.UInt16`
- **Size**: 16-bit unsigned integer
- **Range**: `0` to `65,535`
- **Description**: For non-negative values up to 65,535.
- **Example**:

  ```csharp
  ushort mediumUnsignedNumber = 45000;
  ```

---

### 🔹 32-Bit Integers

#### `int`

- **.NET Type**: `System.Int32`
- **Size**: 32-bit signed integer
- **Range**: `-2,147,483,648` to `2,147,483,647`
- **Description**: Most commonly used integer type.
- **Example**:

  ```csharp
  int largeSignedNumber = 2000000000;
  ```

#### `uint`

- **.NET Type**: `System.UInt32`
- **Size**: 32-bit unsigned integer
- **Range**: `0` to `4,294,967,295`
- **Description**: For large non-negative integers.
- **Example**:

  ```csharp
  uint largeUnsignedNumber = 4000000000U;
  ```

---

### 🔹 64-Bit Integers

#### `long`

- **.NET Type**: `System.Int64`
- **Size**: 64-bit signed integer
- **Range**: `-9,223,372,036,854,775,808` to `9,223,372,036,854,775,807`
- **Description**: For very large integer values.
- **Example**:

  ```csharp
  long veryLargeSignedNumber = -500000000000L;
  ```

#### `ulong`

- **.NET Type**: `System.UInt64`
- **Size**: 64-bit unsigned integer
- **Range**: `0` to `18,446,744,073,709,551,615`
- **Description**: For extremely large non-negative values.
- **Example**:

  ```csharp
  ulong veryLargeUnsignedNumber = 10000000000000000000UL;
  ```

---

### 🔹 Native-Sized Integers (C# 9.0+)

Used in low-level or platform-dependent programming. Size depends on whether the platform is 32-bit or 64-bit.

#### `nint`

- **.NET Type**: `System.IntPtr`
- **Size**: Platform-dependent signed integer
- **Range**: Platform-dependent
- **Example**:

  ```csharp
  nint nativeSignedInt = 123;
  ```

#### `nuint`

- **.NET Type**: `System.UIntPtr`
- **Size**: Platform-dependent unsigned integer
- **Range**: Platform-dependent
- **Example**:

  ```csharp
  nuint nativeUnsignedInt = 456;
  ```

---

## ✅ Summary Table

| Type     | Size   | Signed | Range                           | .NET Type        |
| -------- | ------ | ------ | ------------------------------- | ---------------- |
| `sbyte`  | 8-bit  | Yes    | -128 to 127                     | `System.SByte`   |
| `byte`   | 8-bit  | No     | 0 to 255                        | `System.Byte`    |
| `short`  | 16-bit | Yes    | -32,768 to 32,767               | `System.Int16`   |
| `ushort` | 16-bit | No     | 0 to 65,535                     | `System.UInt16`  |
| `int`    | 32-bit | Yes    | -2,147,483,648 to 2,147,483,647 | `System.Int32`   |
| `uint`   | 32-bit | No     | 0 to 4,294,967,295              | `System.UInt32`  |
| `long`   | 64-bit | Yes    | ±9.2 × 10¹⁸                     | `System.Int64`   |
| `ulong`  | 64-bit | No     | 0 to 18,446,744,073,709,551,615 | `System.UInt64`  |
| `nint`   | Native | Yes    | Platform-dependent              | `System.IntPtr`  |
| `nuint`  | Native | No     | Platform-dependent              | `System.UIntPtr` |

---

Let me know if you'd like this as a downloadable `.md` file or converted to a PDF!
