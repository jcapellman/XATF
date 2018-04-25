#pragma once

#include "XATF.h"

class texture_manager {
	public:
		GLuint LoadTexture(string file_name) {
			if (m_textures.find(file_name) != m_textures.end()) {
				return m_textures[file_name];
			}

			GLuint textureID;
			glGenTextures(1, &textureID);

			m_textures[file_name] = textureID;

			return textureID;
		}
	private:
		map<string, GLuint> m_textures;
};
