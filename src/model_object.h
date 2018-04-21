#pragma once

#include "XATF.h"
#include "texture_manager.h"

class model_object
{
	public:
		void init(texture_manager * t_manager)
		{
			auto textureID = t_manager->LoadTexture("background.bmp");

			m_displayListID = glGenLists(1);

			glNewList(m_displayListID, GL_COMPILE);

			glEnable(GL_TEXTURE_2D);
			glBindTexture(GL_TEXTURE_2D, textureID);
		//	glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, ilGetInteger(IL_IMAGE_WIDTH), ilGetInteger(IL_IMAGE_HEIGHT), 0, GL_RGB, GL_UNSIGNED_BYTE, ilGetData());

			glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR);
			glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR);
			glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_S, GL_REPEAT);
			glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_WRAP_T, GL_REPEAT);

			glBegin(GL_QUADS);			
				glTexCoord2f(0.0f, 0.0f); glVertex3f(-1.0f, -1.0f, 1.0f);
				glTexCoord2f(1.0f, 0.0f); glVertex3f(1.0f, -1.0f, 1.0f);
				glTexCoord2f(1.0f, 1.0f); glVertex3f(1.0f, 1.0f, 1.0f);
				glTexCoord2f(0.0f, 1.0f); glVertex3f(-1.0f, 1.0f, 1.0f);
			glEnd();

			glEndList();
		}

		void render()
		{			
			glCallList(m_displayListID);
		}

		~model_object()
		{
			glDeleteLists(m_displayListID, 1);
		}
	private:		
		GLuint m_displayListID = 0;
};
