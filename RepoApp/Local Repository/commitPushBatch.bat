@echo off

set comment=%1

git add -A
git commit -a -m %comment%
git push origin master