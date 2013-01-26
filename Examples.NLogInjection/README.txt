NLogInjection

This will generate an error because it can't find a matching binding for ILogger.  This is because the Ninject.Extensions.Logging assembly only defines interfaces, not implementaions.  We need to add the nlog2 extension.