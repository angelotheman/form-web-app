# form-web-app
This is a simple form web app created with asp.NET to collect and handle data input from users

## Basic commands to be used
```
git add .
git commit -m "<message>"
git pull
git push
```

Read about them [HERE](https://confluence.atlassian.com/bitbucketserver/basic-git-commands-776639767.html)

# Ways to contribute
1. Navigate to the directory which you want this project to be stored on your local machine
2. Clone the main branch of this repository
3. ```cd``` into the directory and open it in VsCode
4. Create a different branch where you would edit your code. Use this command ```git checkout -b <name>```. _I just used your name + Dev. You can choose whatever name you want_
5. Check that you are currently in your branch with this command ```git branch```. It should display that you are working in your branch.
6. When you are done editing, **push all changes to your branch** ```git push -u origin <name>```. Use this command only once when you do ```git push``` for the first time. In subsequent times, just use ```git push origin <name>```.

## Next Steps
1. Paste all your HTML codes in _Views/Home/Index.cshtml_.
2. Paste all your CSS codes in _Views/Home/Index.cshtml.css_.
3. ```git add Views/Home/Index.cshtml Views/Home/Index.cshtml.css```.
4. ```git commit -m "HTML and CSS added```.
5. Run ```git push origin <name>``` to bring the changes here.
