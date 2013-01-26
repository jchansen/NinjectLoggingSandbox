NLogInjection5

Shows that an error will be produced if both assemblies exist in the project.  They both register themselves, and Ninject doesn't know which ILoggerFactory implemenation to use.