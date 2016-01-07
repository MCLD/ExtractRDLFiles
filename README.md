# ExtractReports

Windows console application to extract .RDL files from a ReportServer database.

Microsoft Reporting services stores RDL files in the SQL Server database as `VARBINARY` data. This
console application will go through all the reports in the database and output them to disk
following the appropriate directory structure.

**NOTE:** some of the resultant RDL files (which are really just XML) may include UTF-8 Bill Of
Materials byte(s) at the start of the file which might need to be removed before Reporting Services
will accept the file.

## How to use

1. Edit the `ExtractRDLFiles.exe.config` file to fix the ConnectionString to point to the Report Server database.
2. Run the program.

The program should create a folder called "ExtractedReports" containing the same directory
structure as your reporting server containing all of the RDL files.

## License

This program is free software: you can redistribute it and/or modify it under the terms of The MIT
License.
