- Install postgreSQL, add \bin folder to PATH
- run `psql -U postgres` in terminal, enter the password you specified during installation
- run `\l` to list all databases
- a couple of useful commands
```
SELECT version();
SELECT inet_server_port();
```
- learn from [neon docs](https://neon.com/postgresql/postgresql-getting-started)

- To run python sample
1. run `pip install -r requirements.txt`
2. set correct values in `database.ini` file
3. run `python .\connect.py`