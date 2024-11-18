## Understanding Format String
A variable or expression can be formatted using a format string after a comma or colon.

An N0 format string means a number with a thousand separators and no decimal places, while a C format string means currency. 
The currency format will be determined by the current thread.

For instance, if you run code that uses the number of currency format on a PC in the UK, you'll get pounds sterling with 
commas as the thousand separators, but if you run it on a PC in Germany, you will get euros with dots as the thousand separators.

The full syntax of a format item is:

```
{ index [, alignment ] [ : formatString ]}
```

Each format item can have an alignment, which is useful when outputting tables of values, some of which migh need to be left- or
right-aligned within a width of characters. Alignment values are integers. Positive integers mean righ-aligned and negative integers
mean left-aligned.

## Custom Number Format

| Format Code | Description |
| ----------- | ----------- |
|   0         | Zero placeholder |
|   #         | Digit placeholder |
|   .         | Decimal point |
|   ,         | Group separator |
|   %         | Percentage placeholder |
|   \         | Escape character |
|   ;         | Section separator |
|   Others    | All others |

## Formatting using simpler format codes
| Format Code | Description |
| ----------- | ----------- |
| C or c      |  Currency   |
| N or n      |  Number     |
| D or d      |  Decimal    |
| B or b      |  Binary     |
| X or x	  |  Exadecimal |
| E or e      |  Exponential|

## Getting text
We can get input from the user using the ReadLine method. This method waits for the user to type some text. Then, as soon as the user
presses Enter, whatever the user has typed is returned as a string value.