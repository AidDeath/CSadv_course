git config --global core.editor "'c:\\TCPU71\\Programm\\Notepad++\\notepad++.exe' -multiInst -notabbar -nosession -noPlugin"

git init

git status

git add .

git commit -m "All homeworks placed in one repo"

git remote add CSadv_course https://github.com/AidDeath/CSadv_course.git

git push --set-upstream CSadv_course master

cd ../

mkdir CSadv_clone

cd CSadv_clone

git clone https://github.com/AidDeath/CSadv_course.git