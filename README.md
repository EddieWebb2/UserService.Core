# UserService.Core 0.0.1

## This is a simple service to collect, store and present user information from multiple sources

### Current Planned State:
- Core service and scheduling logic to be created.
- Registry addition for DI.
- Scheduling logic is currently based on app.config setup.
- Serilog for service logging will be setup.

### Future State:
- Internal Add integration and unit tests to prove functionality
- Internal Api to present schedule information to consumers.
- External Api/Data connector required to modify schedule parameters.
- Internal cache required for schedule parameter refresh.
- Internal make the ProcessForever method accept generic consumers.
- External packages to be built in order to encapsulate Logging an registry dependencies.
