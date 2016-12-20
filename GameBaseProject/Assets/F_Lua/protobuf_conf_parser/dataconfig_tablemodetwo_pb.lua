-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf/protobuf"


local TABLEMODETWO = protobuf.Descriptor();
local TABLEMODETWO_PLAYERLEVEL_FIELD = protobuf.FieldDescriptor();
local TABLEMODETWO_STRENGTHENLIMIT_FIELD = protobuf.FieldDescriptor();
local TABLEMODETWOARRAY = protobuf.Descriptor();
local TABLEMODETWOARRAY_ITEMS_FIELD = protobuf.FieldDescriptor();

TABLEMODETWO_PLAYERLEVEL_FIELD.name = "PlayerLevel"
TABLEMODETWO_PLAYERLEVEL_FIELD.full_name = ".dataconfig.TableModeTwo.PlayerLevel"
TABLEMODETWO_PLAYERLEVEL_FIELD.number = 1
TABLEMODETWO_PLAYERLEVEL_FIELD.index = 0
TABLEMODETWO_PLAYERLEVEL_FIELD.label = 2
TABLEMODETWO_PLAYERLEVEL_FIELD.has_default_value = true
TABLEMODETWO_PLAYERLEVEL_FIELD.default_value = 0
TABLEMODETWO_PLAYERLEVEL_FIELD.type = 13
TABLEMODETWO_PLAYERLEVEL_FIELD.cpp_type = 3

TABLEMODETWO_STRENGTHENLIMIT_FIELD.name = "StrengthenLimit"
TABLEMODETWO_STRENGTHENLIMIT_FIELD.full_name = ".dataconfig.TableModeTwo.StrengthenLimit"
TABLEMODETWO_STRENGTHENLIMIT_FIELD.number = 2
TABLEMODETWO_STRENGTHENLIMIT_FIELD.index = 1
TABLEMODETWO_STRENGTHENLIMIT_FIELD.label = 2
TABLEMODETWO_STRENGTHENLIMIT_FIELD.has_default_value = true
TABLEMODETWO_STRENGTHENLIMIT_FIELD.default_value = 0
TABLEMODETWO_STRENGTHENLIMIT_FIELD.type = 13
TABLEMODETWO_STRENGTHENLIMIT_FIELD.cpp_type = 3

TABLEMODETWO.name = "TableModeTwo"
TABLEMODETWO.full_name = ".dataconfig.TableModeTwo"
TABLEMODETWO.nested_types = {}
TABLEMODETWO.enum_types = {}
TABLEMODETWO.fields = {TABLEMODETWO_PLAYERLEVEL_FIELD, TABLEMODETWO_STRENGTHENLIMIT_FIELD}
TABLEMODETWO.is_extendable = false
TABLEMODETWO.extensions = {}
TABLEMODETWOARRAY_ITEMS_FIELD.name = "items"
TABLEMODETWOARRAY_ITEMS_FIELD.full_name = ".dataconfig.TableModeTwoArray.items"
TABLEMODETWOARRAY_ITEMS_FIELD.number = 1
TABLEMODETWOARRAY_ITEMS_FIELD.index = 0
TABLEMODETWOARRAY_ITEMS_FIELD.label = 3
TABLEMODETWOARRAY_ITEMS_FIELD.has_default_value = false
TABLEMODETWOARRAY_ITEMS_FIELD.default_value = {}
TABLEMODETWOARRAY_ITEMS_FIELD.message_type = TABLEMODETWO
TABLEMODETWOARRAY_ITEMS_FIELD.type = 11
TABLEMODETWOARRAY_ITEMS_FIELD.cpp_type = 10

TABLEMODETWOARRAY.name = "TableModeTwoArray"
TABLEMODETWOARRAY.full_name = ".dataconfig.TableModeTwoArray"
TABLEMODETWOARRAY.nested_types = {}
TABLEMODETWOARRAY.enum_types = {}
TABLEMODETWOARRAY.fields = {TABLEMODETWOARRAY_ITEMS_FIELD}
TABLEMODETWOARRAY.is_extendable = false
TABLEMODETWOARRAY.extensions = {}

TableModeTwo = protobuf.Message(TABLEMODETWO)
TableModeTwoArray = protobuf.Message(TABLEMODETWOARRAY)

--[[Another parser, for the memory reason, use plain table struct 
instead of protobuf table! Auto generated, do not edit!!]]
tablemodetwo_x = {}
tablemodetwo_x.__index = tablemodetwo_x


--[[The class create method]]
function tablemodetwo_x.New()
    local self = {}
    setmetatable(self, tablemodetwo_x)
    self.items = {}
    return self
end


--[[The data parse method, input the protobuf data instance]]
function tablemodetwo_x:ParseData(protobufData)
    for k, v in ipairs(protobufData.items) do 
        local item = {}
        item.PlayerLevel = v.PlayerLevel
        item.StrengthenLimit = v.StrengthenLimit
        table.insert(self.items, item)
    end
end


--[[Get the protobuf instance]]
function tablemodetwo_x:GetProtobuf()
    return TableModeTwoArray()
end