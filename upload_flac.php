<?php
// This file is part of BOINC.
// http://boinc.berkeley.edu
// Copyright (C) 2008 University of California
//
// BOINC is free software; you can redistribute it and/or modify it
// under the terms of the GNU Lesser General Public License
// as published by the Free Software Foundation,
// either version 3 of the License, or (at your option) any later version.
//
// BOINC is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with BOINC.  If not, see <http://www.gnu.org/licenses/>.

require_once("../inc/util.inc");
require_once("../inc/user.inc");
require_once("scripts_config.php");
require_once("custom_functions.php");
global $mysqli;

$user = get_logged_in_user();
page_head(tra("Upload Media Files"));
echo "Use the following form to select .FLAC or .WAV files to upload to encode to FLAC</br></br>";
?>
<form method="post" enctype="multipart/form-data">
    <p>
        <input name="MAX_FILE_SIZE" value="268435456" type="hidden"/>
        Browse for .FLAC or .WAV files to encode:<br/>
        <input name="files[]" type="file" multiple/><br/><br/>
        <input name="upload" type="submit" value="Upload"/>
    </p>
</form>

<?php
if (isset($_POST['upload'])){
    for ($i = 0; $i < count($_FILES['files']['name']); $i++) {
        $random_token = bin2hex(random_bytes(16));
        $file_name = $_FILES["files"]["name"][$i];
        $file_tmp = $_FILES["files"]["tmp_name"][$i];
        $ext = pathinfo($file_name, PATHINFO_EXTENSION);
        $filename = $random_token .".".$ext;
        if (in_array($ext, Array('flac', 'wav'))) {
            if (move_uploaded_file($file_tmp = $_FILES["files"]["tmp_name"][$i], $download_folder . $filename)) {
                chmod($download_folder.$filename, 777);
                chdir($templates_folder);
                $wu_template = fopen($random_token . "_wu", "w");
                fwrite($wu_template, generate_flac_wu_template($random_token.".".$ext, $random_token));
                fclose($wu_template);
                $result_template = fopen($random_token . "_result", "w");
                fwrite($result_template, generate_flac_result_template($random_token));
                fclose($result_template);
                chdir($root_folder);
                exec(return_job_string("flac_encoder", $random_token, $filename));
                insertAudioTrack($mysqli, $user->id, $random_token . "-out.flac", $_FILES["files"]["name"][$i], "flac_encoder");
                rename($download_folder . $filename, $move_folder . $filename);
                echo("Workunit for file " . $_FILES["files"]["name"][$i] . " generated</br>");
            } else {
                echo("File " . $_FILES["files"]["name"][$i] . " failed to upload</br>");
            }
        } else {
            echo("File " . $_FILES["files"]["name"][$i] . " is not a WAV or FLAC file</br>");
        }
    }
}
page_tail();
?>
