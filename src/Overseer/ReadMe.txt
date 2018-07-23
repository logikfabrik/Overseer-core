Overseer.Common.Domain.Model
Base classes and interfaces common to the entire domain model, including domain objects (aggregates, value types, services and so on) declared in referencing projects.

Overseer.Common.Infrastructure
Infrastructure common to this and referencing projects.

Overseer.Domain.Model
The core domain model.

- Events, commands, and handles, should be internal and sealed.
- Aggregates, and value types, should be public, sealed, and only possible to be instantiated using a static factory function (Create(...)).
- Repository interfaces should be internal (for now).
- Service interfaces should be internal (for now).

Overseer.Domain.Services
The core domain services.

Overseer.Framework
Generic extensions to the .NET framework.

Overseer.Infrastructure


Overseer.Desktop
Desktop client. Has references to Overseer.Desktop.Service.AppVeyor and Overseer.Service.AppVeyor for loading the libraries only.