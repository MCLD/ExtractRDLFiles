# ExtractReports

Windows console application which can extract .RDL files from a ReportServer database.

Microsoft Reporting services stores RDL files in the SQL Server database as `VARBINARY` data. This console application will go through all the reports in the database and output them to disk following the appropriate directory structure.

**NOTE:** some of the resultant RDL files (which are really just XML) may include XML Bill Of Materials byte(s) at the start of the file which might need to be removed before Reporting Services will accept the file.