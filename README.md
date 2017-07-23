# SoundCloudJDApp
Test app for adding metadata to SoundCloud songs downloaded with JDownloader

Developed by Patrick Daniel

I made this in a few hours so don't take it too seriously.

JDownloader 2 can download batch download music from SoundCloud.

It's useful. It even gets album art but it doesn't add any metadata.

This app does a quick and dirty job of adding a picture and tags.

It's made for the naming format that JD2 uses.

Songs will look like this:

  Seven Lions & Jason Ross feat. Paul Meany - Higher Love_302507149 - Anjunabeats.mp3
  
And album art will look like this:

  Seven Lions & Jason Ross feat. Paul Meany - Higher Love_500x500_ - Anjunabeats.jpg
  
The album name and artist name are added buy doing some string magic that you can see in MainForm.cs (Album is the song name and artist is the artist)

Useage:

1: Set JD2 to download album art as well as songs

2: Download the music and art to a folder

3: Run SCJDApp and set the mode to tag mode

4: Profit

Have fun.
