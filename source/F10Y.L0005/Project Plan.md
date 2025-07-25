# F10Y.L0005
.NET Standard 2.1 platform library.


Opinions:

?: Is this platform library F10Y-organizationally opinionated?
A: No, but yes. No in the sense that efforts are taken to keep Functionairy-only functionality out of it, but yes in the sense that this library is how Functionairy thinks developers should program.

Allowed:
- Uses overload tokens.
- Uses extended standard types.

Disallowed:
- Strongly-typed - This is the criteria that separates this library from an identical library, but with strong-types.
- Service-based
- IHasX - This is the criteria that separates this library from an identical library, but with strong-types.
- Overload Types


## Instance Placement Progression

Next Steps:
- F10Y.L0000 - .NET Standard 2.1 foundation library.