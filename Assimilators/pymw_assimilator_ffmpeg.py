#!/usr/bin/env python
from assimilator2 import *

if __name__ == '__main__':
    asm = PymwAssimilator("ffmpeg_encoder", assimilator_config.flac_output_path)
    asm.run()
