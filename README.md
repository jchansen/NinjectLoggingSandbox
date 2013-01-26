#Ninject Logging Sandbox

## Description

Some examples that gradually build up an example of using NLog and Log4Net with Ninject:

1. Start with a simple NLog console app.
2. Add Ninject
3. Add the Ninject.Extensions.Logging.nlog2 assembly to enable logging through dependency injection
4. Add the Log4Net extension
5. Resolve the resulting conflict, and show how to switch between them (by unloading the module we don't want)
6. Remove the NLog extension, and show that Log4Net is now recognized as the only binding for ILogger.

## Requirements

* Visual Studio 2012. Does not work with other VS versions.
