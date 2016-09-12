import urllib
import zipfile
import os

# http://stackoverflow.com/a/24623225/5415895

############
# Projects #
############

# Project urls
bubble = "https://www.dropbox.com/sh/9raqb3k5mnle2jk/AACBiZP3YAG1uIuUYKz5R1gia?dl=1"
flapgod2 = "https://www.dropbox.com/sh/6stjl7m9rz1xx57/AAAU0qrl8xxV-oMM7IPpaw_la?dl=1"
triangle_calculator = "https://www.dropbox.com/sh/50gio906qo11zs7/AABlxjXt85QTe2ShjOVckXKQa?dl=1"

# Project names
bubble_filename = "bubble.zip"
flapgod2_filename = "flap_god2.zip"
triangle_calculator_filename = "triangle_calculator.zip"

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

urllib.urlretrieve(bubble, bubble_filename)
urllib.urlretrieve(flapgod2, flapgod2_filename)
urllib.urlretrieve(triangle_calculator, triangle_calculator_filename)

urllib.urlretrieve(resume_image, resume_image_filename)
urllib.urlretrieve(resume, resume_filename)

print("Files downloaded.")

################
# EXTRACT ZIPS #
################

static_folder = "website/Static"
print("Extracting zips.")

bubble_zip = zipfile.ZipFile(bubble_filename, 'r')
bubble_zip.extractall(static_folder + "/Bubble")
bubble_zip.close()
os.remove(bubble_filename)

flap_god2_zip = zipfile.ZipFile(flapgod2_filename, 'r')
flap_god2_zip.extractall(static_folder + '/flap_god2')
flap_god2_zip.close()
os.remove(flapgod2_filename)

triangle_calculator_zip = zipfile.ZipFile(triangle_calculator_filename, 'r')
triangle_calculator_zip.extractall(static_folder + '/triangle_calculator')
triangle_calculator_zip.close()
os.remove(triangle_calculator_filename)

print("Zips extracted.")

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