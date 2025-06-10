- following the [docs](https://redis.io/docs/latest/operate/rc/rc-quickstart/)

0. login to your redis account on the cloud, create/open a db, Get the password from there
1. Set YOUR_PASSWORD in `connect.js`
2. run `npm install redis # first import statement in connect.js`
3. run `node .\connect.js` # it should print "bar" in the console

- Install `redis-cli` using WSL (no standalone windows installation)

```
wsl sudo apt update
wsl sudo apt install redis-tools # this will install `redis-cli`
wsl sudo snap install redis # this will install redis locally
```

Start interactive session with `wsl redis-cli`

- `PING` # should return 'PONG'
- `SET bike:1 "Process 134"`
- `GET bike:1`
