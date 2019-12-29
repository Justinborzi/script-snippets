--[[---------------------------------------------------------
	Name: BlurMenu								  
	Desc: Blurs a given Derma Panel									  
-----------------------------------------------------------]]
local blur = Material("pp/blurscreen")
local function BlurMenu(panel, layers, density, alpha)
    local x, y = panel:LocalToScreen(0, 0)

    surface.SetDrawColor(255, 255, 255, alpha)
    surface.SetMaterial(blur)

    for i = 1, 5 do
        blur:SetFloat("$blur", (i / 4) * 4)
        blur:Recompute()

        render.UpdateScreenEffectTexture()
        surface.DrawTexturedRect(-x, -y, ScrW(), ScrH())
    end
end

--Example Usage
	frame = vgui.Create("DFrame")
	frame:SetPos(-x + 2000, y)
	frame:SetSize(w, h)
	frame:MakePopup()
	frame:ShowCloseButton(false)
	frame:SetDraggable(false)
	frame:SetTitle("")
	frame:MoveTo(0, y, 1, 0, 0.6)
	frame.Paint = function(self)
		BlurMenu(self, 1, 6, 255)
	end
