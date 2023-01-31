# Publish Subscribe
This project demonstrates the Publish/Subscribe pattern. It reads an integer from console, it calculates the tangent of that number, which is then publish to two subscribers that display the result in different formats.

## Running
In order to run the application the [dotnet sdk](https://dotnet.microsoft.com/en-us/download) (version 6.0 or above) needs to installed, and the following command should be ran from the root folder:
```shell
dotnet run --project PublishSubscribe
```
To exit the application press Ctrl+C, or give a wrong formatted input.

### Input/Output example
```
Input an integer and press enter:
1
Long result: 2
Double result: 1.5574077246549023
```

## Testing
There are some unit tests, and system tests written. In order to run these, the the following command should be ran from the root folder:
```shell
dotnet test
```