import urllib
import zipfile
import os

# http://stackoverflow.com/a/24623225/5415895

##########
# Resume #
##########

# Resume urls
resume_image = "https://www.dropbox.com/s/8yri156n7gupu2e/main-1.png?dl=1"
resume = "https://www.dropbox.com/s/cblabl24jqig0nn/main.pdf?dl=1"

# Resume names
resume_filename = "main.pdf"
resume_image_filename = "main.png"

##################
# DOWNLOAD FILES #
##################

print("Downloading files.")

urllib.urlretrieve(resume_image, resume_image_filename)
urllib.urlretrieve(resume, resume_filename)

print("Files downloaded.")

#####################
# MOVE RESUME FILES #
#####################

resume_dir = "website/Content/media/resume"
# http://stackoverflow.com/a/273227/5415895
if not os.path.exists(resume_dir):
	os.makedirs(resume_dir)

# http://stackoverflow.com/a/8858026/5415895
os.rename(resume_filename, resume_dir + "/" + resume_filename)
os.rename(resume_image_filename, resume_dir + "/" + resume_image_filename)