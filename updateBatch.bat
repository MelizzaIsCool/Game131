@echo off

SET url=%1
SET warning=REMEMBER TO COMMIT BEFORE MERGING!
SET question=Would you like to commit

fetch %url%

echo 
echo 