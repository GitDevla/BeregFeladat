import data from './data.json' assert { type: 'json' };
let hazi = data
    .filter(i => i.name.includes("Hazi"))
    .map(i => {
        return {
            "name": i.name.split("-")[1],
            "url": i.ssh_url,
            "branch": i.default_branch
        }
    });

console.log(`git init`);
console.log(`git commit --allow-empty -m "Initial dummy commit"`);
let arr = [];
hazi.forEach(i => {
    console.log(`git remote add --fetch ${i.name} ${i.url}`);
    console.log(`git merge ${i.name}/${i.branch} --allow-unrelated-histories -m "Merge"`);
    console.log(`mkdir ${i.name}`);
    arr.push(i.name);
    console.log(`ls -A -I .git ${arr.map(i => "-I " + i).join(" ")} -p | xargs -I % git mv % ${i.name}/`)
    console.log(`git commit -m "Move ${i.name} files into subdir"`);
});
