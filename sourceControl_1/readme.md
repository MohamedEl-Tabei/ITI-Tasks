# Source Control

### Prerequisites
- Machine that has any OS

### Expected from this course
- How to manage your project versions
- How to use git and github

---


# Day One

### Agenda

- Why we need Version Control?
- What is source Control || Version Control?
- Version Control Types
- How On Earth we get here -- Story about git
- Git Architecture
- Demo
- Labs

---

**Why we need Version Control?**

![Why we need version control](./assets/final_doc.png)


- Kepp track of changes over time.
- Keep track of who did the changes and when.

#### We have two ways of version control:

- Old way, make a folder manually for each version.
- New way, Use Version Control system.

#### Benefit of using V.C.S
- Made a change to code, realised it was a mistake and wanted to revert back?
- Lost code or had a backup that was too old?
- Had to maintain multiple versions of a product?
- Wanted to see the difference between two (or more) versions of your code?
- Wanted to prove that a particular change broke or fixed a piece of code?
- Wanted to review the history of some code?

you can read more on this topic from stack-over flow [Here](https://stackoverflow.com/questions/41604263/how-do-i-display-local-image-in-markdown)


---

### Version Control Types

- Local Version Control
- Centeral Version Control
- Distributed Version Control


**Local Version Control (L.V.C)**

![lvc image](./assets/local.png)


**Centeral Version Control (C.V.C)**

![lvc image](./assets/centeral.jpg)

**Distributed Version Control (C.V.C)**

![lvc image](./assets/DVCS.png)


[Types of Version Control](https://dev.to/meghasharmaaaa/-19l9)


---

### History Of GIT

This is Linus inventor of **GIT and Linux**
![Linus Torvalds](./assets/Linus-Torvalds.webp)

Long story short he wanted to add his project into Free Version Control and he chose **BitKeeper** but at 2001 bitkeeper changed their payment plans due the demond on linux kernal so linus decided to create his own Version Control System 

and named it GIT

---

### Git Architecture And How GIT Works

**What do we need from GIT?**
- Track everything -- changes , who did them and when it happened
- We need to get every change and this will happen by Uniquely Identify the changes -- Unique Id for every change
- Track history
- No content change
- OS Independet 

#### To Track Everything
- we need to know how previous VC were working
- they were working in difference way-- it was saving the difference between the new file and older file while keeping the soruce file.

![how old vc works](./assets/old-vc.png)

- but git work in totally different way.
- GIT takes snapshot of the changed file copy file with the changes
- GIT to keep tracking of the change convert Changes into something called GIT-object.

- GIT object consists of 4 things
    - Blob
    - Tree 
    - Commit
    - Tag annotations

![git object](./assets//git-object.png)

- With every change happens there is Unique id created for the change
- The way GIT creates the id is SHA-1
```bash 
 echo "Hello, git" | git hash-object --stdin   
```

- There is a way you can get the hash SHA-1 on linux by use **shasum**
```bash
echo -e "blob 11\0Hello, git" | shasum
``` 

- But how GIT is OS Independent -- this happenes because git takes approach of reading and writting from files and organize everything in one directory named **.git**
- this folder is on every project initilized with GIT and this folder is where the changes detected and saved.
- then if we need to push the changes remotely it will be pushed from there.

---

### How GIT Works

![git gif](./assets/how-git-works.gif)

---

### Commit Messaging Convention 
- for new feature we use **feat:** such: 
```bash 
feat: add email notifications on new direct messages 
```

- for fixing a bug or an issue we use **fix:** such: 
```bash 
fix: add missing parameter to service call
```
- for documenting the code **docs:**
- for configuring the project like editing prettier or linting or gitignore use **chore:**

---

### Labs

#### Lab One
- create html , css , js files into project name it anything you want.
- initialize git and make 5 commits of changes 
- we need to add a tag as V2.0.0 of the application
- we want to rollback to the second version of changes
- we need to log everything even the refs
- we need to return back to the latest commit
