
# Handling-configuration-settings-values-in-asp.net-core-2.0
In ASP.NET 4.X usually stored in a configuration web.config using a static class to help get these configurations, while the web.config time to make any changes, it will lead to recycle the application pool, this implementation is not very friendly.
ASP.NET Core is a complete rewrite of ASP.NET, the configuration system is overwritten and still use basic key-value pairs, but they are available from a variety of formats, such as command line, environment variables, XML Files, JSON files, etc. You can also write custom configuration source providers.
