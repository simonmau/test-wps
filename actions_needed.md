# 📋 Wartungsplaner Clone – Action Plan

## Milestone 0 – Repository & Solution Setup
- [x] Create `actions_needed.md` with full checklist (this file)
- [ ] Create sub‑folder `src/WartungsplanerClone/`
- [ ] Run `dotnet new sln` to create the solution
- [ ] Add ASP.NET Core Web API project (`Api`)
- [ ] Add Class Library projects for Domain, Application, Infrastructure
- [ ] Add xUnit test project (`Application.Tests`)
- [ ] Wire project references (Api → Application → Domain / Infrastructure)
- [ ] Verify that `dotnet build` succeeds

## Milestone 1 – EF Core & SQLite Baseline
- [ ] Add EF Core + SQLite packages to Infrastructure
- [ ] Create `WartungsplanerContext` with DbSets for core entities
- [ ] Scaffold initial migration and update database
- [ ] Verify that the DB file is created locally

## Milestone 2 – Identity & Authentication
- [ ] Add ASP.NET Core Identity with SQLite store
- [ ] Configure cookie authentication
- [ ] Create `ApplicationUser` inheriting from `IdentityUser<Guid>`
- [ ] Scaffold basic register / login / logout endpoints (or use Minimal APIs)

## Milestone 3 – Multi‑Tenant Model & Seeding
- [ ] Add `Company` entity and relationship to `ApplicationUser`
- [ ] Seed a default Company and an admin user
- [ ] Enforce tenant scoping via query filters or repository base class

## Milestone 4 – Permissions & Authorization
- [ ] Design simple permissions model (Roles + Claims)
- [ ] Implement policies for Billing, CRUD operations, etc.
- [ ] Add service‑level permission checks

## Milestone 5 – Repositories, Services & AutoMapper
- [ ] Create generic `IRepository<T>` and concrete EF implementation
- [ ] Define domain services (`ICompanyService`, `IUserService`, …)
- [ ] Add DTOs and validation attributes
- [ ] Configure AutoMapper profiles

## Milestone 6 – Pagination Infrastructure
- [ ] Implement reusable pagination helper & response wrapper
- [ ] Add unit tests for pagination logic

## Milestone 7 – FileSafeService (Local Filesystem)
- [ ] Define `IFileSafeService` interface
- [ ] Implement local storage using UUID filenames under `.filesafe/`
- [ ] Persist file metadata in the database
- [ ] Create API endpoints for upload / download / delete
- [ ] Add unit/integration tests covering security (tenant isolation)

## Milestone 8 – Auditing
- [ ] Choose audit strategy (Audit table)
- [ ] Implement `IAuditService` that writes records on create/update/delete
- [ ] Hook into EF Core SaveChanges to capture audit entries
- [ ] Unit tests ensuring audit rows are created

## Milestone 9 – PDF Export (QuestPDF)
- [ ] Add QuestPDF package
- [ ] Define `IReportService` and a sample “Maintenance Overview” report
- [ ] Store generated PDFs via `FileSafeService`
- [ ] Expose an endpoint to request the report
- [ ] Tests verifying non‑empty PDF bytes and metadata persistence

## Milestone 10 – Testing Strategy
- [ ] Set up xUnit, FluentAssertions, Moq
- [ ] Write extensive unit tests for all services with business logic
- [ ] Add a few integration tests (auth flow, tenant scoping, a paginated endpoint, file upload)
- [ ] Ensure `dotnet test` passes locally

## Milestone 11 – Documentation & Future‑Proofing
- [ ] Enable Swagger / OpenAPI UI
- [ ] Add health checks endpoint
- [ ] Document folder/project structure in a README
- [ ] Outline how to replace local file storage with S3 later