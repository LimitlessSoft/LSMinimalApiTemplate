This project is created using LSMinimalApi template.

Project template implements LSCore ecosystem used to build APIs fast and easy. For the database, postgres is used (you can change this in `Program.cs`).

To start the project you need to update `appsettings.json` in both `.DbMigrations` and `.Api` projects.
Ater you have done so, run EF update database script from `.DbMigrations` proejct folder, and it will create database with `Users` table and insert first, SYSTEM  user inside it.

After this is done, you can run `.Api` project and start developing
