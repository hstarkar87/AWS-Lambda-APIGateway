Typical Git Project Structure
When you initialize a Git repository (git init), Git creates a hidden folder called .git in the root of your project. This folder contains all the metadata and history for your project.
Example Structure:
my-project/
├── .git/                  # Git metadata (DO NOT TOUCH)
├── README.md              # Project overview
├── .gitignore             # Files/folders Git should ignore
├── services/              # Folder for microservices
│   ├── service-a/
│   │   ├── app.py
│   │   └── requirements.txt
│   └── service-b/
│       ├── index.js
│       └── package.json
├── scripts/               # Utility scripts
├── docs/                  # Documentation
└── docker-compose.yml     # Optional: for container orchestration
🧠 Key Concepts in Git Structure
Component	Purpose
.git/	Stores all Git data (commits, branches, tags, etc.)
README.md	Describes the project, often shown on GitHub
.gitignore	Tells Git which files/folders to ignore (e.g., node_modules/, .env)
services/	Organizes microservices or modules
docs/	Stores documentation or design notes
scripts/	Contains helper scripts (e.g., setup, deploy)
________________________________________
🔄 How Git Tracks Changes
1.	Working Directory: Your actual files.
2.	Staging Area: Files you've marked to be committed (git add).
3.	Repository: Where committed snapshots are stored (git commit).
________________________________________
🧰 Common Git Commands
Command	Description
git init	Initialize a new Git repo
git clone <url>	Copy a remote repo locally
git add .	Stage all changes
git commit -m "message"	Save changes to history
git push	Upload changes to remote
git pull	Download changes from remote

