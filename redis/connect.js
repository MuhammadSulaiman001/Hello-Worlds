import { createClient } from 'redis';

const client = createClient({
    username: 'default',
    password: 'YOUR_PASSWORD',
    socket: {
        host: 'redis-14631.c282.east-us-mz.azure.redns.redis-cloud.com',
        port: 14631
    }
});

client.on('error', err => console.log('Redis Client Error', err));

await client.connect();

await client.set('foo', 'bar');
const result = await client.get('foo');
console.log(result)  // >>> bar

